namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public interface IRelativeHeight // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing.SizeRelativeVerticallyKind? RelativeFrom { get ; set; }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  public System.String? PercentageHeight { get ; set; }
  
}
