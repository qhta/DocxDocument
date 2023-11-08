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
      var element = _Element?.GetFirstChild<DXO13DCS.AxisTitle>();
      if (element != null)
        return AxisTitleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.AxisTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisTitleConverter.CreateOpenXmlElement<DXO13DCS.AxisTitle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.CategoryAxis>();
      if (element != null)
        return CategoryAxisConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.CategoryAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryAxisConverter.CreateOpenXmlElement<DXO13DCS.CategoryAxis>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.ChartArea>();
      if (element != null)
        return ChartAreaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.ChartArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartAreaConverter.CreateOpenXmlElement<DXO13DCS.ChartArea>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DataLabel>();
      if (element != null)
        return DataLabelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DataLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelConverter.CreateOpenXmlElement<DXO13DCS.DataLabel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DataLabelCallout>();
      if (element != null)
        return DataLabelCalloutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DataLabelCallout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelCalloutConverter.CreateOpenXmlElement<DXO13DCS.DataLabelCallout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DataPoint>();
      if (element != null)
        return DataPointConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DataPoint>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPointConverter.CreateOpenXmlElement<DXO13DCS.DataPoint>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DataPoint3D>();
      if (element != null)
        return DataPoint3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DataPoint3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPoint3DConverter.CreateOpenXmlElement<DXO13DCS.DataPoint3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DataPointLine>();
      if (element != null)
        return DataPointLineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DataPointLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPointLineConverter.CreateOpenXmlElement<DXO13DCS.DataPointLine>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DataPointMarker>();
      if (element != null)
        return DataPointMarkerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DataPointMarker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPointMarkerConverter.CreateOpenXmlElement<DXO13DCS.DataPointMarker>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.MarkerLayoutProperties>();
      if (element != null)
        return MarkerLayoutPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.MarkerLayoutProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkerLayoutPropertiesConverter.CreateOpenXmlElement<DXO13DCS.MarkerLayoutProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DataPointWireframe>();
      if (element != null)
        return DataPointWireframeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DataPointWireframe>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPointWireframeConverter.CreateOpenXmlElement<DXO13DCS.DataPointWireframe>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DataTableStyle>();
      if (element != null)
        return DataTableStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DataTableStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataTableStyleConverter.CreateOpenXmlElement<DXO13DCS.DataTableStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DownBar>();
      if (element != null)
        return DownBarConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DownBar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DownBarConverter.CreateOpenXmlElement<DXO13DCS.DownBar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.DropLine>();
      if (element != null)
        return DropLineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.DropLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropLineConverter.CreateOpenXmlElement<DXO13DCS.DropLine>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.ErrorBar>();
      if (element != null)
        return ErrorBarConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.ErrorBar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ErrorBarConverter.CreateOpenXmlElement<DXO13DCS.ErrorBar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.Floor>();
      if (element != null)
        return FloorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.Floor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FloorConverter.CreateOpenXmlElement<DXO13DCS.Floor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.GridlineMajor>();
      if (element != null)
        return GridlineMajorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.GridlineMajor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GridlineMajorConverter.CreateOpenXmlElement<DXO13DCS.GridlineMajor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.GridlineMinor>();
      if (element != null)
        return GridlineMinorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.GridlineMinor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GridlineMinorConverter.CreateOpenXmlElement<DXO13DCS.GridlineMinor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.HiLoLine>();
      if (element != null)
        return HiLoLineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.HiLoLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiLoLineConverter.CreateOpenXmlElement<DXO13DCS.HiLoLine>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.LeaderLine>();
      if (element != null)
        return LeaderLineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.LeaderLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeaderLineConverter.CreateOpenXmlElement<DXO13DCS.LeaderLine>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.LegendStyle>();
      if (element != null)
        return LegendStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.LegendStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegendStyleConverter.CreateOpenXmlElement<DXO13DCS.LegendStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.PlotArea>();
      if (element != null)
        return PlotAreaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.PlotArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotAreaConverter.CreateOpenXmlElement<DXO13DCS.PlotArea>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.PlotArea3D>();
      if (element != null)
        return PlotArea3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.PlotArea3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotArea3DConverter.CreateOpenXmlElement<DXO13DCS.PlotArea3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.SeriesAxis>();
      if (element != null)
        return SeriesAxisConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.SeriesAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesAxisConverter.CreateOpenXmlElement<DXO13DCS.SeriesAxis>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.SeriesLine>();
      if (element != null)
        return SeriesLineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.SeriesLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesLineConverter.CreateOpenXmlElement<DXO13DCS.SeriesLine>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.TitleStyle>();
      if (element != null)
        return TitleStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.TitleStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TitleStyleConverter.CreateOpenXmlElement<DXO13DCS.TitleStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.TrendlineStyle>();
      if (element != null)
        return TrendlineStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.TrendlineStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrendlineStyleConverter.CreateOpenXmlElement<DXO13DCS.TrendlineStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.TrendlineLabel>();
      if (element != null)
        return TrendlineLabelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.TrendlineLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrendlineLabelConverter.CreateOpenXmlElement<DXO13DCS.TrendlineLabel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.UpBar>();
      if (element != null)
        return UpBarConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.UpBar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpBarConverter.CreateOpenXmlElement<DXO13DCS.UpBar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.ValueAxis>();
      if (element != null)
        return ValueAxisConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.ValueAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueAxisConverter.CreateOpenXmlElement<DXO13DCS.ValueAxis>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.Wall>();
      if (element != null)
        return WallConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.Wall>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WallConverter.CreateOpenXmlElement<DXO13DCS.Wall>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13DCS.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
