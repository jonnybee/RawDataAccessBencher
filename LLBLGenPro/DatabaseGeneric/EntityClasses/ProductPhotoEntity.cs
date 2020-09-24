﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'ProductPhoto'.<br/><br/></summary>
	[Serializable]
	public partial class ProductPhotoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProductProductPhotoEntity> _productProductPhotos;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProductPhotoEntityStaticMetaData _staticMetaData = new ProductPhotoEntityStaticMetaData();
		private static ProductPhotoRelations _relationsFactory = new ProductPhotoRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductProductPhotos</summary>
			public static readonly string ProductProductPhotos = "ProductProductPhotos";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductPhotoEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductPhotoEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductPhotoEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.ProductPhotoEntity, typeof(ProductPhotoEntity), typeof(ProductPhotoEntityFactory), false);
				AddNavigatorMetaData<ProductPhotoEntity, EntityCollection<ProductProductPhotoEntity>>("ProductProductPhotos", a => a._productProductPhotos, (a, b) => a._productProductPhotos = b, a => a.ProductProductPhotos, () => new ProductPhotoRelations().ProductProductPhotoEntityUsingProductPhotoId, typeof(ProductProductPhotoEntity), (int)AdventureWorks.Dal.Adapter.EntityType.ProductProductPhotoEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProductPhotoEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProductPhotoEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductPhotoEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductPhotoEntity</param>
		public ProductPhotoEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="productPhotoId">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		public ProductPhotoEntity(System.Int32 productPhotoId) : this(productPhotoId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="productPhotoId">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="validator">The custom validator object for this ProductPhotoEntity</param>
		public ProductPhotoEntity(System.Int32 productPhotoId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ProductPhotoId = productPhotoId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductPhotoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductProductPhoto' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductProductPhotos() { return CreateRelationInfoForNavigator("ProductProductPhotos"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductPhotoEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static ProductPhotoRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductProductPhoto' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductProductPhotos { get { return _staticMetaData.GetPrefetchPathElement("ProductProductPhotos", CommonEntityBase.CreateEntityCollection<ProductProductPhotoEntity>()); } }

		/// <summary>The LargePhoto property of the Entity ProductPhoto<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."LargePhoto".<br/>Table field type characteristics (type, precision, scale, length): VarBinary, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] LargePhoto
		{
			get { return (System.Byte[])GetValue((int)ProductPhotoFieldIndex.LargePhoto, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.LargePhoto, value); }
		}

		/// <summary>The LargePhotoFileName property of the Entity ProductPhoto<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."LargePhotoFileName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String LargePhotoFileName
		{
			get { return (System.String)GetValue((int)ProductPhotoFieldIndex.LargePhotoFileName, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.LargePhotoFileName, value); }
		}

		/// <summary>The ModifiedDate property of the Entity ProductPhoto<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductPhotoFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ProductPhotoId property of the Entity ProductPhoto<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."ProductPhotoID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductPhotoId
		{
			get { return (System.Int32)GetValue((int)ProductPhotoFieldIndex.ProductPhotoId, true); }
			set { SetValue((int)ProductPhotoFieldIndex.ProductPhotoId, value); }		}

		/// <summary>The ThumbNailPhoto property of the Entity ProductPhoto<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."ThumbNailPhoto".<br/>Table field type characteristics (type, precision, scale, length): VarBinary, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] ThumbNailPhoto
		{
			get { return (System.Byte[])GetValue((int)ProductPhotoFieldIndex.ThumbNailPhoto, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.ThumbNailPhoto, value); }
		}

		/// <summary>The ThumbnailPhotoFileName property of the Entity ProductPhoto<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."ThumbnailPhotoFileName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ThumbnailPhotoFileName
		{
			get { return (System.String)GetValue((int)ProductPhotoFieldIndex.ThumbnailPhotoFileName, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.ThumbnailPhotoFileName, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductProductPhotoEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductProductPhotoEntity))]
		public virtual EntityCollection<ProductProductPhotoEntity> ProductProductPhotos { get { return GetOrCreateEntityCollection<ProductProductPhotoEntity, ProductProductPhotoEntityFactory>("ProductPhoto", true, false, ref _productProductPhotos); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum ProductPhotoFieldIndex
	{
		///<summary>LargePhoto. </summary>
		LargePhoto,
		///<summary>LargePhotoFileName. </summary>
		LargePhotoFileName,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductPhotoId. </summary>
		ProductPhotoId,
		///<summary>ThumbNailPhoto. </summary>
		ThumbNailPhoto,
		///<summary>ThumbnailPhotoFileName. </summary>
		ThumbnailPhotoFileName,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductPhoto. </summary>
	public partial class ProductPhotoRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ProductPhotoEntity and ProductProductPhotoEntity over the 1:n relation they have, using the relation between the fields: ProductPhoto.ProductPhotoId - ProductProductPhoto.ProductPhotoId</summary>
		public virtual IEntityRelation ProductProductPhotoEntityUsingProductPhotoId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductProductPhotos", true, new[] { ProductPhotoFields.ProductPhotoId, ProductProductPhotoFields.ProductPhotoId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductPhotoRelations
	{
		internal static readonly IEntityRelation ProductProductPhotoEntityUsingProductPhotoIdStatic = new ProductPhotoRelations().ProductProductPhotoEntityUsingProductPhotoId;

		/// <summary>CTor</summary>
		static StaticProductPhotoRelations() { }
	}
}
