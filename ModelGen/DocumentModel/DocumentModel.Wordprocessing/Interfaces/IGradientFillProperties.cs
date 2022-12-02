namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public interface IGradientFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public DocumentModel.Wordprocessing.IGradientStopList? GradientStopList { get ; set; }
  
  public DocumentModel.Wordprocessing.ILinearShadeProperties? LinearShadeProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.IPathShadeProperties? PathShadeProperties { get ; set; }
  
}
