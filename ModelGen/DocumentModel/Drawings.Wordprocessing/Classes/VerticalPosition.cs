namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Vertical Positioning.
/// </summary>
public partial class VerticalPosition
{
  
  /// <summary>
  ///   Vertical Position Relative Base
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind? RelativeFrom { get; set; }
  
  
  /// <summary>
  ///   Relative Vertical Alignment.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.VerticalAlignment? VerticalAlignment { get; set; }
  
  
  /// <summary>
  ///   PositionOffset.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.PositionOffset? PositionOffset { get; set; }
  
  
  /// <summary>
  ///   PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.PercentagePositionVerticalOffset? PercentagePositionVerticalOffset { get; set; }
  
}
