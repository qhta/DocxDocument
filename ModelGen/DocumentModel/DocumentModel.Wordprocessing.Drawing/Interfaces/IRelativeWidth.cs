namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public interface IRelativeWidth // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeHorizontallyKind? ObjectId { get ; set; }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  public String? PercentageWidth { get ; set; }
  
}
