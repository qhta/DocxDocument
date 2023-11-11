namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Title.
/// </summary>
public partial class Title: ModelElement<DXDC.Title>
{
  public Title(): base(){ }
  
  public Title(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Title(DXDC.Title openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Chart Text.
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
  ///   Overlay.
  /// </summary>
  [DataMember]
  public DMDC.Overlay? Overlay
  {
    get
    {
      return _Element?.GetObject<DMDC.Overlay,DXDC.Overlay>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Overlay,DXDC.Overlay>(value);
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
