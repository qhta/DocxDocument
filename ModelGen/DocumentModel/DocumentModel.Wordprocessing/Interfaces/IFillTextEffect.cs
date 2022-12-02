namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public interface IFillTextEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public System.Boolean? NoFillEmpty { get ; set; }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.ISolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.IGradientFillProperties? GradientFillProperties { get ; set; }
  
}
