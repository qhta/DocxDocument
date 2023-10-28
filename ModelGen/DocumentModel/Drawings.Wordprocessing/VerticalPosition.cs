namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Vertical Positioning.
/// </summary>
public partial class VerticalPosition
{
  
  /// <summary>
  ///   Relative Vertical Alignment.
  /// </summary>
  public DMDW.VerticalAlignment? VerticalAlignment { get; set; }
  
  
  /// <summary>
  ///   PositionOffset.
  /// </summary>
  public DMDW.PositionOffset? PositionOffset { get; set; }
  
  
  /// <summary>
  ///   PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public DMWD.PercentagePositionVerticalOffset? PercentagePositionVerticalOffset { get; set; }
  
}
