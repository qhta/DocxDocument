namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public interface IGradientFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public DocumentModel.Office2010.Word.IGradientStopList? GradientStopList { get ; set; }
  
  public DocumentModel.Office2010.Word.ILinearShadeProperties? LinearShadeProperties { get ; set; }
  
  public DocumentModel.Office2010.Word.IPathShadeProperties? PathShadeProperties { get ; set; }
  
}
