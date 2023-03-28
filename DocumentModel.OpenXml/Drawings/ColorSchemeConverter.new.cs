namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ColorScheme Class converter from/to OpenXml.
///</summary>
public static class ColorSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDraw.ColorScheme openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDraw.ColorScheme openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
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
  private static DMDraws.ThemeColor? GetDark1Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Dark1Color>());
  }
  
  private static bool CmpDark1Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Dark1Color>(), value, diffs, objName);
  }
  
  private static void SetDark1Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Dark1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Dark1Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  private static DMDraws.ThemeColor? GetLight1Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Light1Color>());
  }
  
  private static bool CmpLight1Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Light1Color>(), value, diffs, objName);
  }
  
  private static void SetLight1Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Light1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Light1Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  private static DMDraws.ThemeColor? GetDark2Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Dark2Color>());
  }
  
  private static bool CmpDark2Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Dark2Color>(), value, diffs, objName);
  }
  
  private static void SetDark2Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Dark2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Dark2Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  private static DMDraws.ThemeColor? GetLight2Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Light2Color>());
  }
  
  private static bool CmpLight2Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Light2Color>(), value, diffs, objName);
  }
  
  private static void SetLight2Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Light2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Light2Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  private static DMDraws.ThemeColor? GetAccent1Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Accent1Color>());
  }
  
  private static bool CmpAccent1Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Accent1Color>(), value, diffs, objName);
  }
  
  private static void SetAccent1Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Accent1Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  private static DMDraws.ThemeColor? GetAccent2Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Accent2Color>());
  }
  
  private static bool CmpAccent2Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Accent2Color>(), value, diffs, objName);
  }
  
  private static void SetAccent2Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Accent2Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  private static DMDraws.ThemeColor? GetAccent3Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Accent3Color>());
  }
  
  private static bool CmpAccent3Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Accent3Color>(), value, diffs, objName);
  }
  
  private static void SetAccent3Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent3Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Accent3Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  private static DMDraws.ThemeColor? GetAccent4Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Accent4Color>());
  }
  
  private static bool CmpAccent4Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Accent4Color>(), value, diffs, objName);
  }
  
  private static void SetAccent4Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent4Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Accent4Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  private static DMDraws.ThemeColor? GetAccent5Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Accent5Color>());
  }
  
  private static bool CmpAccent5Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Accent5Color>(), value, diffs, objName);
  }
  
  private static void SetAccent5Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent5Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Accent5Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  private static DMDraws.ThemeColor? GetAccent6Color(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Accent6Color>());
  }
  
  private static bool CmpAccent6Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Accent6Color>(), value, diffs, objName);
  }
  
  private static void SetAccent6Color(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Accent6Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Accent6Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  private static DMDraws.ThemeColor? GetHyperlink(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Hyperlink>());
  }
  
  private static bool CmpHyperlink(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Hyperlink>(), value, diffs, objName);
  }
  
  private static void SetHyperlink(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  private static DMDraws.ThemeColor? GetFollowedHyperlinkColor(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.FollowedHyperlinkColor>());
  }
  
  private static bool CmpFollowedHyperlinkColor(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FollowedHyperlinkColor>(), value, diffs, objName);
  }
  
  private static void SetFollowedHyperlinkColor(DXDraw.ColorScheme openXmlElement, DMDraws.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FollowedHyperlinkColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeColorConverter.CreateOpenXmlElement<DXDraw.FollowedHyperlinkColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.ColorScheme openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.ColorScheme openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName);
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
  
  public static bool CompareModelElement(DXDraw.ColorScheme? openXmlElement, DMDraws.ColorScheme? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpDark1Color(openXmlElement, value.Dark1Color, diffs, objName))
        ok = false;
      if (!CmpLight1Color(openXmlElement, value.Light1Color, diffs, objName))
        ok = false;
      if (!CmpDark2Color(openXmlElement, value.Dark2Color, diffs, objName))
        ok = false;
      if (!CmpLight2Color(openXmlElement, value.Light2Color, diffs, objName))
        ok = false;
      if (!CmpAccent1Color(openXmlElement, value.Accent1Color, diffs, objName))
        ok = false;
      if (!CmpAccent2Color(openXmlElement, value.Accent2Color, diffs, objName))
        ok = false;
      if (!CmpAccent3Color(openXmlElement, value.Accent3Color, diffs, objName))
        ok = false;
      if (!CmpAccent4Color(openXmlElement, value.Accent4Color, diffs, objName))
        ok = false;
      if (!CmpAccent5Color(openXmlElement, value.Accent5Color, diffs, objName))
        ok = false;
      if (!CmpAccent6Color(openXmlElement, value.Accent6Color, diffs, objName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName))
        ok = false;
      if (!CmpFollowedHyperlinkColor(openXmlElement, value.FollowedHyperlinkColor, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
