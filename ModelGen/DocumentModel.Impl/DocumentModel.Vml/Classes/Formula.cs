namespace DocumentModel.Vml;

/// <summary>
/// Single Formula.
/// </summary>
public partial class FormulaImpl: ModelElementImpl, Formula
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Formula? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Formula?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FormulaImpl(): base() {}
  
  public FormulaImpl(DocumentFormat.OpenXml.Vml.Formula openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Equation
  /// </summary>
  public String? Equation
  {
    get => (System.String?)OpenXmlElement?.Equation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Equation = (System.String?)value;
    }
  }
  
}
