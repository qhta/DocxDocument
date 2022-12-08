namespace DocumentModel.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public class Chart2Impl: ModelElementImpl, Chart2
{
  public DocumentFormat.OpenXml.Drawing.Chart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Chart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Series Index
  /// </summary>
  public Int32? SeriesIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Category Index
  /// </summary>
  public Int32? CategoryIndex
  {
    get;
    set;
  }
  
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
