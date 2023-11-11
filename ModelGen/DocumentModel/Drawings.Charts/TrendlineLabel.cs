namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Trendline Label.
/// </summary>
public partial class TrendlineLabel: ModelElement<DXDC.TrendlineLabel>
{
  public TrendlineLabel(): base(){ }
  
  public TrendlineLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TrendlineLabel(DXDC.TrendlineLabel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Layout.
  /// </summary>
  [DataMember]
  public DMDC.Layout? Layout
  {
    get
    {
      return _Element?.GetObject<DMDC.Layout,DXDC.Layout>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Layout,DXDC.Layout>(value);
    }
  }
  
  
  /// <summary>
  ///   ChartText.
  /// </summary>
  [DataMember]
  public DMDC.ChartText? ChartText
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartText,DXDC.ChartText>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartText,DXDC.ChartText>(value);
    }
  }
  
  
  /// <summary>
  ///   Number Format.
  /// </summary>
  [DataMember]
  public DMDC.NumberingFormat? NumberingFormat
  {
    get
    {
      return _Element?.GetObject<DMDC.NumberingFormat,DXDC.NumberingFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumberingFormat,DXDC.NumberingFormat>(value);
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
  ///   TextProperties.
  /// </summary>
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.TextProperties,DXDC.TextProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TextProperties,DXDC.TextProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
