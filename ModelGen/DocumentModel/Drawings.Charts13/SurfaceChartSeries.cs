namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the SurfaceChartSeries Class.
/// </summary>
public partial class SurfaceChartSeries: ModelElement<DXO13DC.SurfaceChartSeries>
{
  public SurfaceChartSeries(): base(){ }
  
  public SurfaceChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceChartSeries(DXO13DC.SurfaceChartSeries openXmlElement): base(openXmlElement) { }
  
  
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
  
  
  /// <summary>
  ///   CategoryAxisData.
  /// </summary>
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
  
  
  /// <summary>
  ///   Values.
  /// </summary>
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
  
  
  /// <summary>
  ///   Bubble3D.
  /// </summary>
  [DataMember]
  public DMDC.Bubble3D? Bubble3D
  {
    get
    {
      return _Element?.GetObject<DMDC.Bubble3D,DXDC.Bubble3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Bubble3D,DXDC.Bubble3D>(value);
    }
  }
  
  
  /// <summary>
  ///   SurfaceSerExtensionList.
  /// </summary>
  [DataMember]
  public DMDC.SurfaceSerExtensionList? SurfaceSerExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.SurfaceSerExtensionList,DXDC.SurfaceSerExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.SurfaceSerExtensionList,DXDC.SurfaceSerExtensionList>(value);
    }
  }
  
}
