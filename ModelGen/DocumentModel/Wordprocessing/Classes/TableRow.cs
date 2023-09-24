namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single table row, which contains the table’s cells. Table rows in WordprocessingML are analogous to HTML tr elements.
/// </summary>
public partial class TableRow
{
  
  /// <summary>
  ///   Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public HexBinary? RsidTableRowMarkRevision { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row
  /// </summary>
  public HexBinary? RsidTableRowAddition { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Deletion
  /// </summary>
  public HexBinary? RsidTableRowDeletion { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Properties
  /// </summary>
  public HexBinary? RsidTableRowProperties { get; set; }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexBinary? ParagraphId { get; set; }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexBinary? TextId { get; set; }
  
  
  /// <summary>
  ///   Table-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptions? TablePropertyExceptions { get; set; }
  
  
  /// <summary>
  ///   Table Row Properties.
  /// </summary>
  public TableRowProperties? TableRowProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
