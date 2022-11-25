namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public interface ITableRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowMarkRevision { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowAddition { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Deletion
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Properties
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowProperties { get ; set; }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? ParagraphId { get ; set; }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? TextId { get ; set; }
  
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.ITablePropertyExceptions? TablePropertyExceptions { get ; set; }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TableRowProperties { get ; set; }
  
}
