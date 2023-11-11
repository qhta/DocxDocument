namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
public partial class UpDownBars: ModelElement<DXDC.UpDownBars>
{
  public UpDownBars(): base(){ }
  
  public UpDownBars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpDownBars(DXDC.UpDownBars openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gap Width.
  /// </summary>
  [DataMember]
  public DMDC.GapWidth? GapWidth
  {
    get
    {
      return _Element?.GetObject<DMDC.GapWidth,DXDC.GapWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.GapWidth,DXDC.GapWidth>(value);
    }
  }
  
  
  /// <summary>
  ///   Up Bars.
  /// </summary>
  [DataMember]
  public DMDC.UpBars? UpBars
  {
    get
    {
      return _Element?.GetObject<DMDC.UpBars,DXDC.UpBars>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.UpBars,DXDC.UpBars>(value);
    }
  }
  
  
  /// <summary>
  ///   Down Bars.
  /// </summary>
  [DataMember]
  public DMDC.DownBars? DownBars
  {
    get
    {
      return _Element?.GetObject<DMDC.DownBars,DXDC.DownBars>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DownBars,DXDC.DownBars>(value);
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
