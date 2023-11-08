namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the CustomUI Class.
/// </summary>
public partial class CustomUI: ModelElement<DXO10CUI.CustomUI>
{
  public CustomUI(): base(){ }
  
  public CustomUI(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomUI(DXO10CUI.CustomUI openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnLoad
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OnLoad);
    }
    set
    {
      _ExistingElement.OnLoad = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? LoadImage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LoadImage);
    }
    set
    {
      _ExistingElement.LoadImage = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Commands.
  /// </summary>
  [DataMember]
  public DMCUI10.Commands? Commands
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.Commands>();
      if (element != null)
        return CommandsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.Commands>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CommandsConverter.CreateOpenXmlElement<DXO10CUI.Commands>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Ribbon.
  /// </summary>
  [DataMember]
  public DMCUI10.Ribbon? Ribbon
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.Ribbon>();
      if (element != null)
        return RibbonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.Ribbon>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RibbonConverter.CreateOpenXmlElement<DXO10CUI.Ribbon>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Backstage.
  /// </summary>
  [DataMember]
  public DMCUI10.Backstage? Backstage
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.Backstage>();
      if (element != null)
        return BackstageConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.Backstage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageConverter.CreateOpenXmlElement<DXO10CUI.Backstage>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ContextMenus.
  /// </summary>
  [DataMember]
  public DMCUI10.ContextMenus? ContextMenus
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.ContextMenus>();
      if (element != null)
        return ContextMenusConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.ContextMenus>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContextMenusConverter.CreateOpenXmlElement<DXO10CUI.ContextMenus>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
