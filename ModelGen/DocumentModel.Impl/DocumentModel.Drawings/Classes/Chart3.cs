namespace DocumentModel.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public class Chart3Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Chart>, Chart3
{
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public ChartBuildStepKind? BuildStep
  {
    get => (ChartBuildStepKind?)OpenXmlElement?.BuildStep?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BuildStep = (DocumentFormat.OpenXml.Drawing.ChartBuildStepValues?)value;
    }
  }
  
}
