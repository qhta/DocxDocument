namespace DocumentModel.Drawings;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public class Pie3DChartImpl: ModelElementImpl, Pie3DChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart?)_OpenXmlElement;
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
  
  public Pie3DChartExtensionList? Pie3DChartExtensionList
  {
    get;
    set;
  }
  
}
