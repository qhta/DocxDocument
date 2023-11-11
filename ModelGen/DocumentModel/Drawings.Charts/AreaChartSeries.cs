namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Area Chart Series.
/// </summary>
public partial class AreaChartSeries: ModelElement<DXDC.AreaChartSeries>
{
  public AreaChartSeries(): base(){ }
  
  public AreaChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AreaChartSeries(DXDC.AreaChartSeries openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC.AreaSerExtensionList? AreaSerExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.AreaSerExtensionList,DXDC.AreaSerExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.AreaSerExtensionList,DXDC.AreaSerExtensionList>(value);
    }
  }
  
}
