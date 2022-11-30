namespace DocumentModel.Office2010.Word.Drawing;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public interface IRelativeHeight // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.Drawing.SizeRelativeVerticallyKind? RelativeFrom { get ; set; }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  public System.String? PercentageHeight { get ; set; }
  
}
