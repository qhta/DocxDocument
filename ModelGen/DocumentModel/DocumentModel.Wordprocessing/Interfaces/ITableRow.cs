namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public interface ITableRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public IHexBinaryValue? RsidTableRowMarkRevision { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row
  /// </summary>
  public IHexBinaryValue? RsidTableRowAddition { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Deletion
  /// </summary>
  public IHexBinaryValue? RsidTableRowDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Properties
  /// </summary>
  public IHexBinaryValue? RsidTableRowProperties { get ; set; }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? ParagraphId { get ; set; }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? TextId { get ; set; }
  
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public ITablePropertyExceptions? TablePropertyExceptions { get ; set; }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public ITableRowProperties? TableRowProperties { get ; set; }
  
}
