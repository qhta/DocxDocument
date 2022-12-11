namespace DocumentModel.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public class DiagramImpl: ModelElementImpl, Diagram
{
  public DocumentFormat.OpenXml.Drawing.Diagram? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagram?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DiagramBuildStepKind? BuildStep
  {
    get => (DiagramBuildStepKind?)OpenXmlElement?.BuildStep?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BuildStep = (DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues?)value;
    }
  }
  
}
