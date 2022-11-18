namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Horizontal Positioning.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.Drawing.IPercentagePositionHeightOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IHorizontalAlignment))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IPositionOffset))]
public interface IHorizontalPosition // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  public HorizontalRelativePosition? RelativeFrom { get ; set; }
  
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
