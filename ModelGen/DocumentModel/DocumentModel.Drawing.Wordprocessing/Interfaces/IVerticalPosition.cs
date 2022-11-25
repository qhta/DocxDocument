namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Vertical Positioning.
/// </summary>
public interface IVerticalPosition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.VerticalRelativePositionKind? RelativeFrom { get ; set; }
  
  /// <summary>
  /// Relative Vertical Alignment.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? VerticalAlignment { get ; set; }
  
  /// <summary>
  /// PositionOffset.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PositionOffset { get ; set; }
  
  /// <summary>
  /// PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PercentagePositionVerticalOffset { get ; set; }
  
}
