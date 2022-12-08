namespace DocumentModel.Drawings;

/// <summary>
/// Pie Charts.
/// </summary>
public class PieChartImpl: ModelElementImpl, PieChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.PieChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors
  {
    get;
    set;
  }
  
  public Collection<PieChartSeries1>? PieChartSerieses
  {
    get;
    set;
  }
  
  public DataLabels2? DataLabels
  {
    get;
    set;
  }
  
  public UInt16? FirstSliceAngle
  {
    get;
    set;
  }
  
  public PieChartExtensionList? PieChartExtensionList
  {
    get;
    set;
  }
  
}
