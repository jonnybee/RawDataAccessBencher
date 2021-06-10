using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.Bencher
{
    [Table("Production.Document")]
	public partial class Document 
	{
		/// <summary>Initializes a new instance of the <see cref="Document"/> class.</summary>
		public Document()
		{
			this.ProductDocuments = new HashSet<ProductDocument>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the ChangeNumber field. </summary>

		public System.Int32 ChangeNumber { get; set; }
		/// <summary>Gets or sets the DocumentLevel field. </summary>

		public Nullable<System.Int16> DocumentLevel { get; set; } /// <summary>Gets or sets the DocumentNode field. </summary>

		public System.String DocumentNode { get; set; }
		/// <summary>Gets or sets the DocumentSummary field. </summary>

		public System.String DocumentSummary { get; set; }
		/// <summary>Gets or sets the DocumentValue field. </summary>

		public System.Byte[] DocumentValue { get; set; }
		/// <summary>Gets or sets the FileExtension field. </summary>

		public System.String FileExtension { get; set; }
		/// <summary>Gets or sets the FileName field. </summary>

		public System.String FileName { get; set; }
		/// <summary>Gets or sets the FolderFlag field. </summary>

		public System.Boolean FolderFlag { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>

		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Owner field. </summary>

		public System.Int32 Owner { get; set; }
		/// <summary>Gets or sets the Revision field. </summary>

		public System.String Revision { get; set; }
		/// <summary>Gets or sets the Rowguid field. </summary>

		public System.Guid Rowguid { get; set; }
		/// <summary>Gets or sets the Status field. </summary>

		public System.Byte Status { get; set; }
		/// <summary>Gets or sets the Title field. </summary>

		public System.String Title { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'Document.Employee - Employee.Documents (m:1)'</summary>

		public virtual Employee Employee { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'ProductDocument.Document - Document.ProductDocuments (m:1)'</summary>

		public virtual ICollection<ProductDocument> ProductDocuments { get; set; }
		#endregion
	}
}
