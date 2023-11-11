namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Display Units Label.
/// </summary>
public partial class DisplayUnitsLabel: ModelElement<DXDC.DisplayUnitsLabel>
{
  public DisplayUnitsLabel(): base(){ }
  
  public DisplayUnitsLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DisplayUnitsLabel(DXDC.DisplayUnitsLabel openXmlElement): base(openXmlElement) { }
  
  
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
  
}
