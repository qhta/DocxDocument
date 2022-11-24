namespace DocumentModel.Office2010.Word.Drawing;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public interface IRelativeWidth // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeHorizontallyValues? ObjectId { get ; set; }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  public IPercentageWidth? PercentageWidth { get ; set; }
  
}
