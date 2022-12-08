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
  
  /// <summary>
  /// Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
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
