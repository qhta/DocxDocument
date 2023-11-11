namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ChartStyle Class.
/// </summary>
public partial class ChartStyle: ModelElement<DXO13DCS.ChartStyle>
{
  public ChartStyle(): base(){ }
  
  public ChartStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartStyle(DXO13DCS.ChartStyle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
  
  /// <summary>
  ///   AxisTitle.
  /// </summary>
  [DataMember]
  public DMDCS.AxisTitle? AxisTitle
  {
    get
    {
      return _Element?.GetObject<DMDCS.AxisTitle,DXO13DCS.AxisTitle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.AxisTitle,DXO13DCS.AxisTitle>(value);
    }
  }
  
  
  /// <summary>
  ///   CategoryAxis.
  /// </summary>
  [DataMember]
  public DMDCS.CategoryAxis? CategoryAxis
  {
    get
    {
      return _Element?.GetObject<DMDCS.CategoryAxis,DXO13DCS.CategoryAxis>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.CategoryAxis,DXO13DCS.CategoryAxis>(value);
    }
  }
  
  
  /// <summary>
  ///   ChartArea.
  /// </summary>
  [DataMember]
  public DMDCS.ChartArea? ChartArea
  {
    get
    {
      return _Element?.GetObject<DMDCS.ChartArea,DXO13DCS.ChartArea>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.ChartArea,DXO13DCS.ChartArea>(value);
    }
  }
  
  
  /// <summary>
  ///   DataLabel.
  /// </summary>
  [DataMember]
  public DMDCS.DataLabel? DataLabel
  {
    get
    {
      return _Element?.GetObject<DMDCS.DataLabel,DXO13DCS.DataLabel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DataLabel,DXO13DCS.DataLabel>(value);
    }
  }
  
  
  /// <summary>
  ///   DataLabelCallout.
  /// </summary>
  [DataMember]
  public DMDCS.DataLabelCallout? DataLabelCallout
  {
    get
    {
      return _Element?.GetObject<DMDCS.DataLabelCallout,DXO13DCS.DataLabelCallout>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DataLabelCallout,DXO13DCS.DataLabelCallout>(value);
    }
  }
  
  
  /// <summary>
  ///   DataPoint.
  /// </summary>
  [DataMember]
  public DMDCS.DataPoint? DataPoint
  {
    get
    {
      return _Element?.GetObject<DMDCS.DataPoint,DXO13DCS.DataPoint>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DataPoint,DXO13DCS.DataPoint>(value);
    }
  }
  
  
  /// <summary>
  ///   DataPoint3D.
  /// </summary>
  [DataMember]
  public DMDCS.DataPoint3D? DataPoint3D
  {
    get
    {
      return _Element?.GetObject<DMDCS.DataPoint3D,DXO13DCS.DataPoint3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DataPoint3D,DXO13DCS.DataPoint3D>(value);
    }
  }
  
  
  /// <summary>
  ///   DataPointLine.
  /// </summary>
  [DataMember]
  public DMDCS.DataPointLine? DataPointLine
  {
    get
    {
      return _Element?.GetObject<DMDCS.DataPointLine,DXO13DCS.DataPointLine>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DataPointLine,DXO13DCS.DataPointLine>(value);
    }
  }
  
  
  /// <summary>
  ///   DataPointMarker.
  /// </summary>
  [DataMember]
  public DMDCS.DataPointMarker? DataPointMarker
  {
    get
    {
      return _Element?.GetObject<DMDCS.DataPointMarker,DXO13DCS.DataPointMarker>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DataPointMarker,DXO13DCS.DataPointMarker>(value);
    }
  }
  
  
  /// <summary>
  ///   MarkerLayoutProperties.
  /// </summary>
  [DataMember]
  public DMDCS.MarkerLayoutProperties? MarkerLayoutProperties
  {
    get
    {
      return _Element?.GetObject<DMDCS.MarkerLayoutProperties,DXO13DCS.MarkerLayoutProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.MarkerLayoutProperties,DXO13DCS.MarkerLayoutProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   DataPointWireframe.
  /// </summary>
  [DataMember]
  public DMDCS.DataPointWireframe? DataPointWireframe
  {
    get
    {
      return _Element?.GetObject<DMDCS.DataPointWireframe,DXO13DCS.DataPointWireframe>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DataPointWireframe,DXO13DCS.DataPointWireframe>(value);
    }
  }
  
  
  /// <summary>
  ///   DataTableStyle.
  /// </summary>
  [DataMember]
  public DMDCS.DataTableStyle? DataTableStyle
  {
    get
    {
      return _Element?.GetObject<DMDCS.DataTableStyle,DXO13DCS.DataTableStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DataTableStyle,DXO13DCS.DataTableStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   DownBar.
  /// </summary>
  [DataMember]
  public DMDCS.DownBar? DownBar
  {
    get
    {
      return _Element?.GetObject<DMDCS.DownBar,DXO13DCS.DownBar>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DownBar,DXO13DCS.DownBar>(value);
    }
  }
  
  
  /// <summary>
  ///   DropLine.
  /// </summary>
  [DataMember]
  public DMDCS.DropLine? DropLine
  {
    get
    {
      return _Element?.GetObject<DMDCS.DropLine,DXO13DCS.DropLine>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.DropLine,DXO13DCS.DropLine>(value);
    }
  }
  
  
  /// <summary>
  ///   ErrorBar.
  /// </summary>
  [DataMember]
  public DMDCS.ErrorBar? ErrorBar
  {
    get
    {
      return _Element?.GetObject<DMDCS.ErrorBar,DXO13DCS.ErrorBar>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.ErrorBar,DXO13DCS.ErrorBar>(value);
    }
  }
  
  
  /// <summary>
  ///   Floor.
  /// </summary>
  [DataMember]
  public DMDCS.Floor? Floor
  {
    get
    {
      return _Element?.GetObject<DMDCS.Floor,DXO13DCS.Floor>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.Floor,DXO13DCS.Floor>(value);
    }
  }
  
  
  /// <summary>
  ///   GridlineMajor.
  /// </summary>
  [DataMember]
  public DMDCS.GridlineMajor? GridlineMajor
  {
    get
    {
      return _Element?.GetObject<DMDCS.GridlineMajor,DXO13DCS.GridlineMajor>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.GridlineMajor,DXO13DCS.GridlineMajor>(value);
    }
  }
  
  
  /// <summary>
  ///   GridlineMinor.
  /// </summary>
  [DataMember]
  public DMDCS.GridlineMinor? GridlineMinor
  {
    get
    {
      return _Element?.GetObject<DMDCS.GridlineMinor,DXO13DCS.GridlineMinor>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.GridlineMinor,DXO13DCS.GridlineMinor>(value);
    }
  }
  
  
  /// <summary>
  ///   HiLoLine.
  /// </summary>
  [DataMember]
  public DMDCS.HiLoLine? HiLoLine
  {
    get
    {
      return _Element?.GetObject<DMDCS.HiLoLine,DXO13DCS.HiLoLine>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.HiLoLine,DXO13DCS.HiLoLine>(value);
    }
  }
  
  
  /// <summary>
  ///   LeaderLine.
  /// </summary>
  [DataMember]
  public DMDCS.LeaderLine? LeaderLine
  {
    get
    {
      return _Element?.GetObject<DMDCS.LeaderLine,DXO13DCS.LeaderLine>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.LeaderLine,DXO13DCS.LeaderLine>(value);
    }
  }
  
  
  /// <summary>
  ///   LegendStyle.
  /// </summary>
  [DataMember]
  public DMDCS.LegendStyle? LegendStyle
  {
    get
    {
      return _Element?.GetObject<DMDCS.LegendStyle,DXO13DCS.LegendStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.LegendStyle,DXO13DCS.LegendStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   PlotArea.
  /// </summary>
  [DataMember]
  public DMDCS.PlotArea? PlotArea
  {
    get
    {
      return _Element?.GetObject<DMDCS.PlotArea,DXO13DCS.PlotArea>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.PlotArea,DXO13DCS.PlotArea>(value);
    }
  }
  
  
  /// <summary>
  ///   PlotArea3D.
  /// </summary>
  [DataMember]
  public DMDCS.PlotArea3D? PlotArea3D
  {
    get
    {
      return _Element?.GetObject<DMDCS.PlotArea3D,DXO13DCS.PlotArea3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.PlotArea3D,DXO13DCS.PlotArea3D>(value);
    }
  }
  
  
  /// <summary>
  ///   SeriesAxis.
  /// </summary>
  [DataMember]
  public DMDCS.SeriesAxis? SeriesAxis
  {
    get
    {
      return _Element?.GetObject<DMDCS.SeriesAxis,DXO13DCS.SeriesAxis>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.SeriesAxis,DXO13DCS.SeriesAxis>(value);
    }
  }
  
  
  /// <summary>
  ///   SeriesLine.
  /// </summary>
  [DataMember]
  public DMDCS.SeriesLine? SeriesLine
  {
    get
    {
      return _Element?.GetObject<DMDCS.SeriesLine,DXO13DCS.SeriesLine>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.SeriesLine,DXO13DCS.SeriesLine>(value);
    }
  }
  
  
  /// <summary>
  ///   TitleStyle.
  /// </summary>
  [DataMember]
  public DMDCS.TitleStyle? TitleStyle
  {
    get
    {
      return _Element?.GetObject<DMDCS.TitleStyle,DXO13DCS.TitleStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.TitleStyle,DXO13DCS.TitleStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   TrendlineStyle.
  /// </summary>
  [DataMember]
  public DMDCS.TrendlineStyle? TrendlineStyle
  {
    get
    {
      return _Element?.GetObject<DMDCS.TrendlineStyle,DXO13DCS.TrendlineStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.TrendlineStyle,DXO13DCS.TrendlineStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   TrendlineLabel.
  /// </summary>
  [DataMember]
  public DMDCS.TrendlineLabel? TrendlineLabel
  {
    get
    {
      return _Element?.GetObject<DMDCS.TrendlineLabel,DXO13DCS.TrendlineLabel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.TrendlineLabel,DXO13DCS.TrendlineLabel>(value);
    }
  }
  
  
  /// <summary>
  ///   UpBar.
  /// </summary>
  [DataMember]
  public DMDCS.UpBar? UpBar
  {
    get
    {
      return _Element?.GetObject<DMDCS.UpBar,DXO13DCS.UpBar>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.UpBar,DXO13DCS.UpBar>(value);
    }
  }
  
  
  /// <summary>
  ///   ValueAxis.
  /// </summary>
  [DataMember]
  public DMDCS.ValueAxis? ValueAxis
  {
    get
    {
      return _Element?.GetObject<DMDCS.ValueAxis,DXO13DCS.ValueAxis>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.ValueAxis,DXO13DCS.ValueAxis>(value);
    }
  }
  
  
  /// <summary>
  ///   Wall.
  /// </summary>
  [DataMember]
  public DMDCS.Wall? Wall
  {
    get
    {
      return _Element?.GetObject<DMDCS.Wall,DXO13DCS.Wall>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.Wall,DXO13DCS.Wall>(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDCS.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDCS.OfficeArtExtensionList,DXO13DCS.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.OfficeArtExtensionList,DXO13DCS.OfficeArtExtensionList>(value);
    }
  }
  
}
