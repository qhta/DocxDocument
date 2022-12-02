namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public interface IGradientFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public IGradientStopList? GradientStopList { get ; set; }
  
  public ILinearShadeProperties? LinearShadeProperties { get ; set; }
  
  public IPathShadeProperties? PathShadeProperties { get ; set; }
  
}
