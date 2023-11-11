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
      return _Element?.GetObject<DMCUI10.Commands,DXO10CUI.Commands>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.Commands,DXO10CUI.Commands>(value);
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
      return _Element?.GetObject<DMCUI10.Ribbon,DXO10CUI.Ribbon>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.Ribbon,DXO10CUI.Ribbon>(value);
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
      return _Element?.GetObject<DMCUI10.Backstage,DXO10CUI.Backstage>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.Backstage,DXO10CUI.Backstage>(value);
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
      return _Element?.GetObject<DMCUI10.ContextMenus,DXO10CUI.ContextMenus>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.ContextMenus,DXO10CUI.ContextMenus>(value);
    }
  }
  
}
