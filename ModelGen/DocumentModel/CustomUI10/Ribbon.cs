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
        _ExistingElement.StartFromScratch = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXO10CUI.QuickAccessToolbar>();
      if (element != null)
        return QuickAccessToolbarConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.QuickAccessToolbar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = QuickAccessToolbarConverter.CreateOpenXmlElement<DXO10CUI.QuickAccessToolbar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO10CUI.Tabs>();
      if (element != null)
        return TabsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.Tabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TabsConverter.CreateOpenXmlElement<DXO10CUI.Tabs>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO10CUI.ContextualTabs>();
      if (element != null)
        return ContextualTabsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.ContextualTabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContextualTabsConverter.CreateOpenXmlElement<DXO10CUI.ContextualTabs>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
