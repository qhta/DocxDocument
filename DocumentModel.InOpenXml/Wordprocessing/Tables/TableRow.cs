namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a table row in a Wordprocessing document.
/// This class provides access to revision identifiers, paragraph and text IDs, property exceptions, row properties, and enables advanced configuration and management of table rows and their content.
/// </summary>
[DataContract]
[XmlRoot("TableRow", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableRow : ModelElement<DXW.TableRow>, ITableContent, ISdtRowContent
{
 /// <summary>
 /// Revision identifier for table row glyph formatting.
 /// </summary>
 public HexInt? RsidTableRowMarkRevision { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Revision identifier for table row addition.
 /// </summary>
 public HexInt? RsidTableRowAddition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Revision identifier for table row deletion.
 /// </summary>
 public HexInt? RsidTableRowDeletion { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Revision identifier for table row properties.
 /// </summary>
 public HexInt? RsidTableRowProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Paragraph identifier for the row.
 /// </summary>
 public HexInt? ParagraphId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Text identifier for the row.
 /// </summary>
 public HexInt? TextId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Table-level property exceptions for the row, enabling advanced formatting overrides.
 /// </summary>
 public TablePropertyExceptions? TablePropertyExceptions { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Table row properties, including formatting and layout options for the row.
 /// </summary>
 public TableRowProperties? TableRowProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}