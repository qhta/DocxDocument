namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleChartSeries Class.
/// </summary>
public partial class BubbleChartSeries: ModelElement<DXDC.BubbleChartSeries>
{
  public BubbleChartSeries(): base(){ }
  
  public BubbleChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BubbleChartSeries(DXDC.BubbleChartSeries openXmlElement): base(openXmlElement) { }
  
  
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
  ///   InvertIfNegative.
  /// </summary>
  [DataMember]
  public DMDC.InvertIfNegative? InvertIfNegative
  {
    get
    {
      return _Element?.GetObject<DMDC.InvertIfNegative,DXDC.InvertIfNegative>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.InvertIfNegative,DXDC.InvertIfNegative>(value);
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
  public DMDC.BubbleSize? BubbleSize
  {
    get
    {
      return _Element?.GetObject<DMDC.BubbleSize,DXDC.BubbleSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.BubbleSize,DXDC.BubbleSize>(value);
    }
  }
  
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
  
  [DataMember]
  public DMDC.BubbleSerExtensionList? BubbleSerExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.BubbleSerExtensionList,DXDC.BubbleSerExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.BubbleSerExtensionList,DXDC.BubbleSerExtensionList>(value);
    }
  }
  
}
