namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the RelativeHeight Class.
/// </summary>
public partial class RelativeHeight
{
  
  /// <summary>
  ///   relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("relativeFrom")]
  public DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyValues? RelativeFrom { get; set; }
  
  
  /// <summary>
  ///   PercentageHeight.
  /// </summary>
  public String? PercentageHeight { get; set; }
  
}
