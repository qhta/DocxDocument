namespace DocumentModel.Vml;

/// <summary>
/// Complex.
/// </summary>
public class ComplexImpl: ModelElementImpl, Complex
{
  public DocumentFormat.OpenXml.Vml.Office.Complex? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Complex?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ComplexImpl(): base() {}
  
  public ComplexImpl(DocumentFormat.OpenXml.Vml.Office.Complex openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
}
