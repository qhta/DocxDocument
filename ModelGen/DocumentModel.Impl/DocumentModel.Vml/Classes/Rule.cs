namespace DocumentModel.Vml;

/// <summary>
/// Rule.
/// </summary>
public class RuleImpl: ModelElementImpl, Rule
{
  public DocumentFormat.OpenXml.Vml.Office.Rule? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Rule?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RuleImpl(): base() {}
  
  public RuleImpl(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Rule ID
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public RuleKind? Type
  {
    get => (RuleKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.RuleValues?)value;
    }
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public AlignmentKind? How
  {
    get => (AlignmentKind?)OpenXmlElement?.How?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.How = (DocumentFormat.OpenXml.Vml.Office.AlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  public String? ShapeReference
  {
    get => (String?)OpenXmlElement?.ShapeReference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeReference = (System.String?)value;
    }
  }
  
  public Collection<Proxy>? Proxies
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
