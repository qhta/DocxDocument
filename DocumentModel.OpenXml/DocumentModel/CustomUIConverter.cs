namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the CustomUI Class.
/// </summary>
public static class CustomUIConverter
{
  /// <summary>
  ///   onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnLoad(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    return openXmlElement?.OnLoad?.Value;
  }

  public static void SetOnLoad(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnLoad = new StringValue { Value = value };
      else
        openXmlElement.OnLoad = null;
  }

  /// <summary>
  ///   loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLoadImage(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    return openXmlElement?.LoadImage?.Value;
  }

  public static void SetLoadImage(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LoadImage = new StringValue { Value = value };
      else
        openXmlElement.LoadImage = null;
  }

  /// <summary>
  ///   Commands.
  /// </summary>
  public static Commands? GetCommands(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>();
    if (itemElement != null)
      return CommandsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommands(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, Commands? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CommandsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ribbon.
  /// </summary>
  public static Ribbon? GetRibbon(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>();
    if (itemElement != null)
      return RibbonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRibbon(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, Ribbon? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RibbonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Backstage.
  /// </summary>
  public static Backstage? GetBackstage(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>();
    if (itemElement != null)
      return BackstageConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstage(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, Backstage? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ContextMenus.
  /// </summary>
  public static ContextMenus? GetContextMenus(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>();
    if (itemElement != null)
      return ContextMenusConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetContextMenus(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, ContextMenus? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContextMenusConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CustomUI? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new CustomUI();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(CustomUI? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI, new()
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