namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Horizontal Positioning.
/// </summary>
public partial class HorizontalPosition
{
  
  /// <summary>
  ///   Horizontal Position Relative Base
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind? RelativeFrom { get; set; }
  
  
  /// <summary>
  ///   Relative Horizontal Alignment.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.HorizontalAlignment? HorizontalAlignment { get; set; }
  
  
  /// <summary>
  ///   Absolute Position Offset.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.PositionOffset? PositionOffset { get; set; }
  
  
  /// <summary>
  ///   PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.PercentagePositionHeightOffset? PercentagePositionHeightOffset { get; set; }
  
}
