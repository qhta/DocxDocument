namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single table row, which contains the table’s cells. Table rows in WordprocessingML are analogous to HTML tr elements.
/// </summary>
public partial class TableRow
{
  
  /// <summary>
  ///   Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  [SchemaAttr("w:rsidRPr")]
  public DocumentModel.HexBinaryValue? RsidTableRowMarkRevision { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row
  /// </summary>
  [SchemaAttr("w:rsidR")]
  public DocumentModel.HexBinaryValue? RsidTableRowAddition { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Deletion
  /// </summary>
  [SchemaAttr("w:rsidDel")]
  public DocumentModel.HexBinaryValue? RsidTableRowDeletion { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Properties
  /// </summary>
  [SchemaAttr("w:rsidTr")]
  public DocumentModel.HexBinaryValue? RsidTableRowProperties { get; set; }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:paraId")]
  public DocumentModel.HexBinaryValue? ParagraphId { get; set; }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:textId")]
  public DocumentModel.HexBinaryValue? TextId { get; set; }
  
  
  /// <summary>
  ///   Table-Level Property Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TablePropertyExceptions? TablePropertyExceptions { get; set; }
  
  
  /// <summary>
  ///   Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowProperties? TableRowProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
