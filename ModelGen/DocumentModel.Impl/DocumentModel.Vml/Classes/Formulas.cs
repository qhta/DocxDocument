namespace DocumentModel.Vml;

/// <summary>
/// Defines the Formulas Class.
/// </summary>
public class FormulasImpl: ModelElementImpl, Formulas
{
  public DocumentFormat.OpenXml.Vml.Formulas? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Formulas?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Formula>? Items
  {
    get;
    set;
  }
  
}
