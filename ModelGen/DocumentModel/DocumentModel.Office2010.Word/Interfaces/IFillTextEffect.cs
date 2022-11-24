namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public interface IFillTextEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public INoFillEmpty? NoFillEmpty { get ; set; }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public ISolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public IGradientFillProperties? GradientFillProperties { get ; set; }
  
}
