namespace DocumentModel.Office2010.Word.Drawing;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.Drawing.IPercentageWidth))]
public interface IRelativeWidth // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeHorizontally? ObjectId { get ; set; }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  public IPercentageWidth? PercentageWidth { get ; set; }
  
}
