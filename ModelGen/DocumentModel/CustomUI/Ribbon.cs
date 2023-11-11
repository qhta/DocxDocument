namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public partial class Ribbon: ModelElement<DXOCUI.Ribbon>
{
  public Ribbon(): base(){ }
  
  public Ribbon(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Ribbon(DXOCUI.Ribbon openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   startFromScratch
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
  ///   OfficeMenu.
  /// </summary>
  [DataMember]
  public DMCUI.OfficeMenu? OfficeMenu
  {
    get
    {
      return _Element?.GetObject<DMCUI.OfficeMenu,DXOCUI.OfficeMenu>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.OfficeMenu,DXOCUI.OfficeMenu>(value);
    }
  }
  
  
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  [DataMember]
  public DMCUI.QuickAccessToolbar? QuickAccessToolbar
  {
    get
    {
      return _Element?.GetObject<DMCUI.QuickAccessToolbar,DXOCUI.QuickAccessToolbar>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.QuickAccessToolbar,DXOCUI.QuickAccessToolbar>(value);
    }
  }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  [DataMember]
  public DMCUI.Tabs? Tabs
  {
    get
    {
      return _Element?.GetObject<DMCUI.Tabs,DXOCUI.Tabs>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.Tabs,DXOCUI.Tabs>(value);
    }
  }
  
  
  /// <summary>
  ///   ContextualTabSets.
  /// </summary>
  [DataMember]
  public DMCUI.ContextualTabSets? ContextualTabSets
  {
    get
    {
      return _Element?.GetObject<DMCUI.ContextualTabSets,DXOCUI.ContextualTabSets>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.ContextualTabSets,DXOCUI.ContextualTabSets>(value);
    }
  }
  
}
