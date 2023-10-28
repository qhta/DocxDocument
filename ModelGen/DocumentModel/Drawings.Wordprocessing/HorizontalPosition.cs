namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Horizontal Positioning.
/// </summary>
public partial class HorizontalPosition
{
  
  /// <summary>
  ///   Relative Horizontal Alignment.
  /// </summary>
  public DMDW.HorizontalAlignment? HorizontalAlignment { get; set; }
  
  
  /// <summary>
  ///   Absolute Position Offset.
  /// </summary>
  public DMDW.PositionOffset? PositionOffset { get; set; }
  
  
  /// <summary>
  ///   PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public DMWD.PercentagePositionHeightOffset? PercentagePositionHeightOffset { get; set; }
  
}
