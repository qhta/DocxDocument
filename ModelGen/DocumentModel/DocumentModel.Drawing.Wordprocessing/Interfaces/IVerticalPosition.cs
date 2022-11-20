namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Vertical Positioning.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.Drawing.IPercentagePositionVerticalOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IVerticalAlignment))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IPositionOffset))]
public interface IVerticalPosition // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
