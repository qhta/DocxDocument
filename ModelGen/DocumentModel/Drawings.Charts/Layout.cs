namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Layout.
/// </summary>
public partial class Layout: ModelElement<DXDC.Layout>
{
  public Layout(): base(){ }
  
  public Layout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Layout(DXDC.Layout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Manual Layout.
  /// </summary>
  [DataMember]
  public DMDC.ManualLayout? ManualLayout
  {
    get
    {
      return _Element?.GetObject<DMDC.ManualLayout,DXDC.ManualLayout>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ManualLayout,DXDC.ManualLayout>(value);
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
