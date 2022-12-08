namespace DocumentModel.Drawings;

/// <summary>
/// Doughnut Charts.
/// </summary>
public class DoughnutChartImpl: ModelElementImpl, DoughnutChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart?)_OpenXmlElement;
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
  
  public Byte? HoleSize
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
