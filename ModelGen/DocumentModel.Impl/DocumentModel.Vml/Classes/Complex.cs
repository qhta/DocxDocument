namespace DocumentModel.Vml;

/// <summary>
/// Complex.
/// </summary>
public partial class ComplexImpl: ModelElementImpl, Complex
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.Complex? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Complex?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ComplexImpl(): base() {}
  
  public ComplexImpl(DocumentFormat.OpenXml.Vml.Office.Complex openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
}
