namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Vertical Positioning.
/// </summary>
public partial class VerticalPosition
{
  
  /// <summary>
  ///   Vertical Position Relative Base
  /// </summary>
  [SchemaAttr("relativeFrom")]
  public DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionValues? RelativeFrom { get; set; }
  
  
  /// <summary>
  ///   Relative Vertical Alignment.
  /// </summary>
  public String? VerticalAlignment { get; set; }
  
  
  /// <summary>
  ///   PositionOffset.
  /// </summary>
  public String? PositionOffset { get; set; }
  
  
  /// <summary>
  ///   PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public String? PercentagePositionVerticalOffset { get; set; }
  
}
