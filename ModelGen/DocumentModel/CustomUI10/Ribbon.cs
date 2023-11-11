namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public partial class Ribbon: ModelElement<DXO10CUI.Ribbon>
{
  public Ribbon(): base(){ }
  
  public Ribbon(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Ribbon(DXO10CUI.Ribbon openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? StartFromScratch
  {
    get
    {
      return _Element?.StartFromScratch?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.StartFromScratch = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.StartFromScratch = null;
    }
  }
  
  
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  [DataMember]
  public DMCUI10.QuickAccessToolbar? QuickAccessToolbar
  {
    get
    {
      return _Element?.GetObject<DMCUI10.QuickAccessToolbar,DXO10CUI.QuickAccessToolbar>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.QuickAccessToolbar,DXO10CUI.QuickAccessToolbar>(value);
    }
  }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  [DataMember]
  public DMCUI10.Tabs? Tabs
  {
    get
    {
      return _Element?.GetObject<DMCUI10.Tabs,DXO10CUI.Tabs>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.Tabs,DXO10CUI.Tabs>(value);
    }
  }
  
  
  /// <summary>
  ///   ContextualTabs.
  /// </summary>
  [DataMember]
  public DMCUI10.ContextualTabs? ContextualTabs
  {
    get
    {
      return _Element?.GetObject<DMCUI10.ContextualTabs,DXO10CUI.ContextualTabs>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.ContextualTabs,DXO10CUI.ContextualTabs>(value);
    }
  }
  
}
