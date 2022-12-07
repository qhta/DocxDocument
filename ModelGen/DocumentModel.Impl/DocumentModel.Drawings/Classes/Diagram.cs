namespace DocumentModel.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public class DiagramImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagram>, Diagram
{
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
