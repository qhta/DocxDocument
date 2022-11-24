namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public interface IHorizontalPosition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  public HorizontalRelativePositionValues? RelativeFrom { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  public IHorizontalAlignment? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  public IPositionOffset? PositionOffset { get ; set; }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public IPercentagePositionHeightOffset? PercentagePositionHeightOffset { get ; set; }
  
}
