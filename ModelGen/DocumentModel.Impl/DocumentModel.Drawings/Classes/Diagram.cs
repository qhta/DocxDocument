namespace DocumentModel.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public partial class DiagramImpl: ModelElementImpl, Diagram
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagram? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagram?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DiagramImpl(): base() {}
  
  public DiagramImpl(DocumentFormat.OpenXml.Drawing.Diagram openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DocumentModel.Drawings.DiagramBuildStepKind? BuildStep
  {
    get => (DocumentModel.Drawings.DiagramBuildStepKind?)OpenXmlElement?.BuildStep?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BuildStep = (DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues?)value;
    }
  }
  
}
