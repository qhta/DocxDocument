namespace DocumentModel.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public partial class ChartImpl: ModelElementImpl, Chart
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Chart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Chart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChartImpl(): base() {}
  
  public ChartImpl(DocumentFormat.OpenXml.Drawing.Chart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Series Index
  /// </summary>
  public Int32? SeriesIndex
  {
    get => (System.Int32?)OpenXmlElement?.SeriesIndex?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SeriesIndex = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Category Index
  /// </summary>
  public Int32? CategoryIndex
  {
    get => (System.Int32?)OpenXmlElement?.CategoryIndex?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CategoryIndex = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DocumentModel.Drawings.ChartBuildStepKind? BuildStep
  {
    get => (DocumentModel.Drawings.ChartBuildStepKind?)OpenXmlElement?.BuildStep?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BuildStep = (DocumentFormat.OpenXml.Drawing.ChartBuildStepValues?)value;
    }
  }
  
}
