using EFCore.Bencher;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RawBencher.Benchers
{
    /// <summary>
    /// Specific bencher for Entity Framework, doing no change tracking fetch
    /// </summary>
    public class EntityFrameworkCoreCompiledQueryAsNoTrackingBencher : FetchOnlyBencherBase<EFCore.Bencher.EntityClasses.SalesOrderHeader>
    {
        private readonly PooledDbContextFactory<AWDataContext> pooledDbContextFactory;
        private readonly bool enableThreadSafetyChecks;
        private static Func<AWDataContext, int, EFCore.Bencher.EntityClasses.SalesOrderHeader> _fetchIndividual = 
            EF.CompileQuery((AWDataContext ctx, int key) => 
               ctx.SalesOrderHeaders.AsNoTracking().Single(e => e.SalesOrderId == key));  // Must use AsNoTracking()
        
        private static Func<AWDataContext, IEnumerable<EFCore.Bencher.EntityClasses.SalesOrderHeader>> _fetchList =
            EF.CompileQuery((AWDataContext ctx) =>
               ctx.SalesOrderHeaders.AsNoTracking());  // Must use AsNoTracking to get fast materialization

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityFrameworkCoreNoChangeTrackingBencher"/> class.
        /// </summary>
        public EntityFrameworkCoreCompiledQueryAsNoTrackingBencher(string connectionString, bool enableThreadSafetyChecks = false)
            : base(e => e.SalesOrderId, usesChangeTracking: false, usesCaching: false)
        {
            var options = new DbContextOptionsBuilder<AWDataContext>()
                .UseSqlServer(connectionString)
                .EnableThreadSafetyChecks(enableThreadSafetyChecks)
                .Options;

            pooledDbContextFactory = new PooledDbContextFactory<AWDataContext>(options);
            this.enableThreadSafetyChecks = enableThreadSafetyChecks;
        }


        /// <summary>
        /// Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override EFCore.Bencher.EntityClasses.SalesOrderHeader FetchIndividual(int key)
        {
            using (var ctx = pooledDbContextFactory.CreateDbContext())
            {
                return _fetchIndividual(ctx, key);
            }
        }


        /// <summary>
        /// Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<EFCore.Bencher.EntityClasses.SalesOrderHeader> FetchSet()
        {
            using (var ctx = pooledDbContextFactory.CreateDbContext())
            {
                return _fetchList(ctx).ToList();
            }
        }


        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
        {
            if (enableThreadSafetyChecks)
                return CreateFrameworkName("EFCore CQ ANT v{0}", typeof(Microsoft.EntityFrameworkCore.DbContext));
            else
                return CreateFrameworkName("EFCore CQ ANT NTSC v{0}", typeof(Microsoft.EntityFrameworkCore.DbContext));
        }
    }
}
