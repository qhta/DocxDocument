namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public interface IFillTextEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public Boolean? NoFillEmpty { get ; set; }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public ISolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public IGradientFillProperties? GradientFillProperties { get ; set; }
  
}
