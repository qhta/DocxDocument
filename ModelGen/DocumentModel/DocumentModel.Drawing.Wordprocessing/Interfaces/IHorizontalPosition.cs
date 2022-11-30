namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public interface IHorizontalPosition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.HorizontalRelativePositionKind? RelativeFrom { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  public System.String? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  public System.String? PositionOffset { get ; set; }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public System.String? PercentagePositionHeightOffset { get ; set; }
  
}
