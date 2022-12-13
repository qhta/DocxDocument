namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
public class ChartStyleImpl: ModelElementImpl, ChartStyle
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartStyleImpl(): base() {}
  
  public ChartStyleImpl(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id
  {
    get => (System.UInt32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// AxisTitle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.AxisTitle? AxisTitle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  public DocumentModel.Drawings13.Charts.CategoryAxis? CategoryAxis
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  public DocumentModel.Drawings13.Charts.ChartArea? ChartArea
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataLabel? DataLabel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataLabelCallout? DataLabelCallout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPoint? DataPoint
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPoint3D? DataPoint3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPointLine? DataPointLine
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPointMarker? DataPointMarker
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  public DocumentModel.Drawings13.Charts.MarkerLayoutProperties? MarkerLayoutProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPointWireframe? DataPointWireframe
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataTableStyle? DataTableStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DownBar? DownBar
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DropLine? DropLine
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  public DocumentModel.Drawings13.Charts.ErrorBar? ErrorBar
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Floor.
  /// </summary>
  public DocumentModel.Drawings13.Charts.Floor? Floor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  public DocumentModel.Drawings13.Charts.GridlineMajor? GridlineMajor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  public DocumentModel.Drawings13.Charts.GridlineMinor? GridlineMinor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.HiLoLine? HiLoLine
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.LeaderLine? LeaderLine
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.LegendStyle? LegendStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Drawings13.Charts.PlotArea? PlotArea
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  public DocumentModel.Drawings13.Charts.PlotArea3D? PlotArea3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  public DocumentModel.Drawings13.Charts.SeriesAxis? SeriesAxis
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.SeriesLine? SeriesLine
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.TitleStyle? TitleStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.TrendlineStyle? TrendlineStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  public DocumentModel.Drawings13.Charts.TrendlineLabel? TrendlineLabel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  public DocumentModel.Drawings13.Charts.UpBar? UpBar
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  public DocumentModel.Drawings13.Charts.ValueAxis? ValueAxis
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Wall.
  /// </summary>
  public DocumentModel.Drawings13.Charts.Wall? Wall
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings13.Charts.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
