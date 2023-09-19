namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Table Cell Properties.
/// </summary>
public partial class TableCellPropertiesChange
{
  
  /// <summary>
  ///   author
  /// </summary>
  [SchemaAttr("w:author")]
  public String? Author { get; set; }
  
  
  /// <summary>
  ///   date
  /// </summary>
  [SchemaAttr("w:date")]
  public DateTime? Date { get; set; }
  
  
  /// <summary>
  ///   dateUtc, this property is only available in Microsoft365 and later.
  /// </summary>
  [SchemaAttr("w16du:dateUtc")]
  public DateTime? DateUtc { get; set; }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [SchemaAttr("w:id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Previous Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousTableCellProperties? PreviousTableCellProperties { get; set; }
  
}
