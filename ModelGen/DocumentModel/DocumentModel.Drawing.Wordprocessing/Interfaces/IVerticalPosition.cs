namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Vertical Positioning.
/// </summary>
public interface IVerticalPosition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  public VerticalRelativePositionValues? RelativeFrom { get ; set; }
  
  /// <summary>
  /// Relative Vertical Alignment.
  /// </summary>
  public IVerticalAlignment? VerticalAlignment { get ; set; }
  
  /// <summary>
  /// PositionOffset.
  /// </summary>
  public IPositionOffset? PositionOffset { get ; set; }
  
  /// <summary>
  /// PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public IPercentagePositionVerticalOffset? PercentagePositionVerticalOffset { get ; set; }
  
}
