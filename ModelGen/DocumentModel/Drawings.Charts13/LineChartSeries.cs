namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the LineChartSeries Class.
/// </summary>
public partial class LineChartSeries: ModelElement<DXO13DC.LineChartSeries>
{
  public LineChartSeries(): base(){ }
  
  public LineChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineChartSeries(DXO13DC.LineChartSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index.
  /// </summary>
  [DataMember]
  public DMDC.Index? Index
  {
    get
    {
      return _Element?.GetObject<DMDC.Index,DXDC.Index>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Index,DXDC.Index>(value);
    }
  }
  
  
  /// <summary>
  ///   Order.
  /// </summary>
  [DataMember]
  public DMDC.Order? Order
  {
    get
    {
      return _Element?.GetObject<DMDC.Order,DXDC.Order>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Order,DXDC.Order>(value);
    }
  }
  
  
  /// <summary>
  ///   Series Text.
  /// </summary>
  [DataMember]
  public DMDC.SeriesText? SeriesText
  {
    get
    {
      return _Element?.GetObject<DMDC.SeriesText,DXDC.SeriesText>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.SeriesText,DXDC.SeriesText>(value);
    }
  }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  [DataMember]
  public DMDC.Marker? Marker
  {
    get
    {
      return _Element?.GetObject<DMDC.Marker,DXDC.Marker>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Marker,DXDC.Marker>(value);
    }
  }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  [DataMember]
  public DMDC.PictureOptions? PictureOptions
  {
    get
    {
      return _Element?.GetObject<DMDC.PictureOptions,DXDC.PictureOptions>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PictureOptions,DXDC.PictureOptions>(value);
    }
  }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      return _Element?.GetObject<DMDC.DataLabels,DXDC.DataLabels>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DataLabels,DXDC.DataLabels>(value);
    }
  }
  
  [DataMember]
  public DMDC.ErrorBars? ErrorBars
  {
    get
    {
      return _Element?.GetObject<DMDC.ErrorBars,DXDC.ErrorBars>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ErrorBars,DXDC.ErrorBars>(value);
    }
  }
  
  [DataMember]
  public DMDC.CategoryAxisData? CategoryAxisData
  {
    get
    {
      return _Element?.GetObject<DMDC.CategoryAxisData,DXDC.CategoryAxisData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.CategoryAxisData,DXDC.CategoryAxisData>(value);
    }
  }
  
  [DataMember]
  public DMDC.Values? Values
  {
    get
    {
      return _Element?.GetObject<DMDC.Values,DXDC.Values>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Values,DXDC.Values>(value);
    }
  }
  
  [DataMember]
  public DMDC.Smooth? Smooth
  {
    get
    {
      return _Element?.GetObject<DMDC.Smooth,DXDC.Smooth>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Smooth,DXDC.Smooth>(value);
    }
  }
  
  [DataMember]
  public DMDC.LineSerExtensionList? LineSerExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.LineSerExtensionList,DXDC.LineSerExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.LineSerExtensionList,DXDC.LineSerExtensionList>(value);
    }
  }
  
}
