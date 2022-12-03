namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public interface HorizontalPosition // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  public HorizontalRelativePositionKind? RelativeFrom { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  public String? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  public String? PositionOffset { get ; set; }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public String? PercentagePositionHeightOffset { get ; set; }
  
}
