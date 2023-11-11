namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ScatterChartSeries Class.
/// </summary>
public partial class ScatterChartSeries: ModelElement<DXDC.ScatterChartSeries>
{
  public ScatterChartSeries(): base(){ }
  
  public ScatterChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScatterChartSeries(DXDC.ScatterChartSeries openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC.XValues? XValues
  {
    get
    {
      return _Element?.GetObject<DMDC.XValues,DXDC.XValues>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.XValues,DXDC.XValues>(value);
    }
  }
  
  [DataMember]
  public DMDC.YValues? YValues
  {
    get
    {
      return _Element?.GetObject<DMDC.YValues,DXDC.YValues>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.YValues,DXDC.YValues>(value);
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
  public DMDC.ScatterSerExtensionList? ScatterSerExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ScatterSerExtensionList,DXDC.ScatterSerExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ScatterSerExtensionList,DXDC.ScatterSerExtensionList>(value);
    }
  }
  
}
