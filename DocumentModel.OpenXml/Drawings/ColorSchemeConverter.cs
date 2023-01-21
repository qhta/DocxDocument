namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ColorScheme Class.
/// </summary>
public static class ColorSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDraw.ColorScheme openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDraw.ColorScheme openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Dark 1.
  /// </summary>
  private static DMDraws.Dark1Color? GetDark1Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Dark1Color>();
    if (itemElement != null)
      return DMXDraws.Dark1ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDark1Color(DXDraw.ColorScheme openXmlElement, DMDraws.Dark1Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Dark1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Dark1ColorConverter.CreateOpenXmlElement<DXDraw.Dark1Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  private static DMDraws.Light1Color? GetLight1Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Light1Color>();
    if (itemElement != null)
      return DMXDraws.Light1ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLight1Color(DXDraw.ColorScheme openXmlElement, DMDraws.Light1Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Light1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Light1ColorConverter.CreateOpenXmlElement<DXDraw.Light1Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  private static DMDraws.Dark2Color? GetDark2Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Dark2Color>();
    if (itemElement != null)
      return DMXDraws.Dark2ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDark2Color(DXDraw.ColorScheme openXmlElement, DMDraws.Dark2Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Dark2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Dark2ColorConverter.CreateOpenXmlElement<DXDraw.Dark2Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  private static DMDraws.Light2Color? GetLight2Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Light2Color>();
    if (itemElement != null)
      return DMXDraws.Light2ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLight2Color(DXDraw.ColorScheme openXmlElement, DMDraws.Light2Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Light2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Light2ColorConverter.CreateOpenXmlElement<DXDraw.Light2Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  private static DMDraws.Accent1Color? GetAccent1Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Accent1Color>();
    if (itemElement != null)
      return DMXDraws.Accent1ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccent1Color(DXDraw.ColorScheme openXmlElement, DMDraws.Accent1Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Accent1ColorConverter.CreateOpenXmlElement<DXDraw.Accent1Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  private static DMDraws.Accent2Color? GetAccent2Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Accent2Color>();
    if (itemElement != null)
      return DMXDraws.Accent2ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccent2Color(DXDraw.ColorScheme openXmlElement, DMDraws.Accent2Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Accent2ColorConverter.CreateOpenXmlElement<DXDraw.Accent2Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  private static DMDraws.Accent3Color? GetAccent3Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Accent3Color>();
    if (itemElement != null)
      return DMXDraws.Accent3ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccent3Color(DXDraw.ColorScheme openXmlElement, DMDraws.Accent3Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent3Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Accent3ColorConverter.CreateOpenXmlElement<DXDraw.Accent3Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  private static DMDraws.Accent4Color? GetAccent4Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Accent4Color>();
    if (itemElement != null)
      return DMXDraws.Accent4ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccent4Color(DXDraw.ColorScheme openXmlElement, DMDraws.Accent4Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent4Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Accent4ColorConverter.CreateOpenXmlElement<DXDraw.Accent4Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  private static DMDraws.Accent5Color? GetAccent5Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Accent5Color>();
    if (itemElement != null)
      return DMXDraws.Accent5ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccent5Color(DXDraw.ColorScheme openXmlElement, DMDraws.Accent5Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent5Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Accent5ColorConverter.CreateOpenXmlElement<DXDraw.Accent5Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  private static DMDraws.Accent6Color? GetAccent6Color(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Accent6Color>();
    if (itemElement != null)
      return DMXDraws.Accent6ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccent6Color(DXDraw.ColorScheme openXmlElement, DMDraws.Accent6Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent6Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Accent6ColorConverter.CreateOpenXmlElement<DXDraw.Accent6Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  private static DMDraws.Hyperlink? GetHyperlink(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Hyperlink>();
    if (itemElement != null)
      return DMXDraws.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlink(DXDraw.ColorScheme openXmlElement, DMDraws.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkConverter.CreateOpenXmlElement<DXDraw.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  private static DMDraws.FollowedHyperlinkColor? GetFollowedHyperlinkColor(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FollowedHyperlinkColor>();
    if (itemElement != null)
      return DMXDraws.FollowedHyperlinkColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFollowedHyperlinkColor(DXDraw.ColorScheme openXmlElement, DMDraws.FollowedHyperlinkColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FollowedHyperlinkColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FollowedHyperlinkColorConverter.CreateOpenXmlElement<DXDraw.FollowedHyperlinkColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.ColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.ColorScheme openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ColorScheme? CreateModelElement(DXDraw.ColorScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ColorScheme();
      value.Name = GetName(openXmlElement);
      value.Dark1Color = GetDark1Color(openXmlElement);
      value.Light1Color = GetLight1Color(openXmlElement);
      value.Dark2Color = GetDark2Color(openXmlElement);
      value.Light2Color = GetLight2Color(openXmlElement);
      value.Accent1Color = GetAccent1Color(openXmlElement);
      value.Accent2Color = GetAccent2Color(openXmlElement);
      value.Accent3Color = GetAccent3Color(openXmlElement);
      value.Accent4Color = GetAccent4Color(openXmlElement);
      value.Accent5Color = GetAccent5Color(openXmlElement);
      value.Accent6Color = GetAccent6Color(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.FollowedHyperlinkColor = GetFollowedHyperlinkColor(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ColorScheme? value)
    where OpenXmlElementType: DXDraw.ColorScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetDark1Color(openXmlElement, value?.Dark1Color);
      SetLight1Color(openXmlElement, value?.Light1Color);
      SetDark2Color(openXmlElement, value?.Dark2Color);
      SetLight2Color(openXmlElement, value?.Light2Color);
      SetAccent1Color(openXmlElement, value?.Accent1Color);
      SetAccent2Color(openXmlElement, value?.Accent2Color);
      SetAccent3Color(openXmlElement, value?.Accent3Color);
      SetAccent4Color(openXmlElement, value?.Accent4Color);
      SetAccent5Color(openXmlElement, value?.Accent5Color);
      SetAccent6Color(openXmlElement, value?.Accent6Color);
      SetHyperlink(openXmlElement, value?.Hyperlink);
      SetFollowedHyperlinkColor(openXmlElement, value?.FollowedHyperlinkColor);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
