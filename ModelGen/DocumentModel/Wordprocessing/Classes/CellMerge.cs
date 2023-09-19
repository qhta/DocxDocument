namespace DocumentModel.Wordprocessing;


/// <summary>
///   Vertically Merged/Split Table Cells.
/// </summary>
public partial class CellMerge
{
  
  /// <summary>
  ///   vMerge
  /// </summary>
  [SchemaAttr("w:vMerge")]
  public DocumentModel.Wordprocessing.VerticalMergeRevisionValues? VerticalMerge { get; set; }
  
  
  /// <summary>
  ///   vMergeOrig
  /// </summary>
  [SchemaAttr("w:vMergeOrig")]
  public DocumentModel.Wordprocessing.VerticalMergeRevisionValues? VerticalMergeOriginal { get; set; }
  
  
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
  
}
