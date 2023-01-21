namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the CustomUI Class.
/// </summary>
public static class CustomUIConverter
{
  /// <summary>
  /// onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnLoad(DXO2010CustUI.CustomUI openXmlElement)
  {
    return openXmlElement?.OnLoad?.Value;
  }
  
  private static void SetOnLoad(DXO2010CustUI.CustomUI openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnLoad = new StringValue { Value = value };
    else
      openXmlElement.OnLoad = null;
  }
  
  /// <summary>
  /// loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLoadImage(DXO2010CustUI.CustomUI openXmlElement)
  {
    return openXmlElement?.LoadImage?.Value;
  }
  
  private static void SetLoadImage(DXO2010CustUI.CustomUI openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LoadImage = new StringValue { Value = value };
    else
      openXmlElement.LoadImage = null;
  }
  
  /// <summary>
  /// Commands.
  /// </summary>
  private static DM.Commands? GetCommands(DXO2010CustUI.CustomUI openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.Commands>();
    if (itemElement != null)
      return DMX.CommandsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCommands(DXO2010CustUI.CustomUI openXmlElement, DM.Commands? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Commands>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CommandsConverter.CreateOpenXmlElement<DXO2010CustUI.Commands>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  private static DM.Ribbon? GetRibbon(DXO2010CustUI.CustomUI openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.Ribbon>();
    if (itemElement != null)
      return DMX.RibbonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRibbon(DXO2010CustUI.CustomUI openXmlElement, DM.Ribbon? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Ribbon>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.RibbonConverter.CreateOpenXmlElement<DXO2010CustUI.Ribbon>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Backstage.
  /// </summary>
  private static DM.Backstage? GetBackstage(DXO2010CustUI.CustomUI openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.Backstage>();
    if (itemElement != null)
      return DMX.BackstageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstage(DXO2010CustUI.CustomUI openXmlElement, DM.Backstage? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Backstage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageConverter.CreateOpenXmlElement<DXO2010CustUI.Backstage>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextMenus.
  /// </summary>
  private static DM.ContextMenus? GetContextMenus(DXO2010CustUI.CustomUI openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ContextMenus>();
    if (itemElement != null)
      return DMX.ContextMenusConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetContextMenus(DXO2010CustUI.CustomUI openXmlElement, DM.ContextMenus? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ContextMenus>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ContextMenusConverter.CreateOpenXmlElement<DXO2010CustUI.ContextMenus>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.CustomUI? CreateModelElement(DXO2010CustUI.CustomUI? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.CustomUI();
      value.OnLoad = GetOnLoad(openXmlElement);
      value.LoadImage = GetLoadImage(openXmlElement);
      value.Commands = GetCommands(openXmlElement);
      value.Ribbon = GetRibbon(openXmlElement);
      value.Backstage = GetBackstage(openXmlElement);
      value.ContextMenus = GetContextMenus(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.CustomUI? value)
    where OpenXmlElementType: DXO2010CustUI.CustomUI, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnLoad(openXmlElement, value?.OnLoad);
      SetLoadImage(openXmlElement, value?.LoadImage);
      SetCommands(openXmlElement, value?.Commands);
      SetRibbon(openXmlElement, value?.Ribbon);
      SetBackstage(openXmlElement, value?.Backstage);
      SetContextMenus(openXmlElement, value?.ContextMenus);
      return openXmlElement;
    }
    return default;
  }
}
