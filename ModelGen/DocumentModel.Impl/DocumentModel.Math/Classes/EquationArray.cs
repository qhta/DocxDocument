namespace DocumentModel.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public class EquationArrayImpl: ModelElementImpl, EquationArray
{
  public DocumentFormat.OpenXml.Math.EquationArray? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.EquationArray?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  public EquationArrayProperties? EquationArrayProperties
  {
    get;
    set;
  }
  
  public Collection<Base>? Bases
  {
    get;
    set;
  }
  
}
