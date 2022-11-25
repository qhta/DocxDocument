namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public interface IGradientFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GradientStopList { get ; set; }
  
}
