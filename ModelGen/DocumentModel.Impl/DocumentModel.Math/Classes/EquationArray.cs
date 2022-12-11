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
  
  public EquationArrayImpl(): base() {}
  
  public EquationArrayImpl(DocumentFormat.OpenXml.Math.EquationArray openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  public EquationArrayProperties? EquationArrayProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
