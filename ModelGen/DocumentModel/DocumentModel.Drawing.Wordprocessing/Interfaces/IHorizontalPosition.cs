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
  public DocumentModel.BaseTypes.ModelElement? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PositionOffset { get ; set; }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PercentagePositionHeightOffset { get ; set; }
  
}
