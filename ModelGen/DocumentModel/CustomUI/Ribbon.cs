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
        _ExistingElement.StartFromScratch = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXOCUI.OfficeMenu>();
      if (element != null)
        return OfficeMenuConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.OfficeMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeMenuConverter.CreateOpenXmlElement<DXOCUI.OfficeMenu>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXOCUI.QuickAccessToolbar>();
      if (element != null)
        return QuickAccessToolbarConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.QuickAccessToolbar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = QuickAccessToolbarConverter.CreateOpenXmlElement<DXOCUI.QuickAccessToolbar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXOCUI.Tabs>();
      if (element != null)
        return TabsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.Tabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TabsConverter.CreateOpenXmlElement<DXOCUI.Tabs>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXOCUI.ContextualTabSets>();
      if (element != null)
        return ContextualTabSetsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.ContextualTabSets>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContextualTabSetsConverter.CreateOpenXmlElement<DXOCUI.ContextualTabSets>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
