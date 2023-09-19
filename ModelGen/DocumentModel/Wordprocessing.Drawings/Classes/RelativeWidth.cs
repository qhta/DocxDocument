namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the RelativeWidth Class.
/// </summary>
public partial class RelativeWidth
{
  
  /// <summary>
  ///   relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("relativeFrom")]
  public DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyValues? ObjectId { get; set; }
  
  
  /// <summary>
  ///   PercentageWidth.
  /// </summary>
  public String? PercentageWidth { get; set; }
  
}
