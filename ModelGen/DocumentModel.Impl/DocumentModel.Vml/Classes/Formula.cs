namespace DocumentModel.Vml;

/// <summary>
/// Single Formula.
/// </summary>
public class FormulaImpl: ModelElementImpl, Formula
{
  public DocumentFormat.OpenXml.Vml.Formula? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Formula?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Equation
  /// </summary>
  public String? Equation
  {
    get;
    set;
  }
  
}
