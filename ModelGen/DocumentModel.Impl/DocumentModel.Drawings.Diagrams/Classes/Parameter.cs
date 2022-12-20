namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public partial class ParameterImpl: ModelElementImpl, Parameter
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.Parameter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Parameter?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ParameterImpl(): base() {}
  
  public ParameterImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Parameter Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ParameterIdKind? Type
  {
    get => (DocumentModel.Drawings.Diagrams.ParameterIdKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues?)value;
    }
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
