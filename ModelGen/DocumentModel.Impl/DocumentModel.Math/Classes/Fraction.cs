namespace DocumentModel.Math;

/// <summary>
/// Fraction Function.
/// </summary>
public class FractionImpl: ModelElementImpl, Fraction
{
  public DocumentFormat.OpenXml.Math.Fraction? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Fraction?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FractionImpl(): base() {}
  
  public FractionImpl(DocumentFormat.OpenXml.Math.Fraction openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Fraction Properties.
  /// </summary>
  public DocumentModel.Math.FractionProperties? FractionProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Numerator.
  /// </summary>
  public DocumentModel.Math.Numerator? Numerator
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Denominator.
  /// </summary>
  public DocumentModel.Math.Denominator? Denominator
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
