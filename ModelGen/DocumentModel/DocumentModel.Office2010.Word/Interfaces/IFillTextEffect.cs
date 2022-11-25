namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public interface IFillTextEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? NoFillEmpty { get ; set; }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.ISolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.IGradientFillProperties? GradientFillProperties { get ; set; }
  
}
