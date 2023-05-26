namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ColorScheme Class.
/// </summary>
public static class ColorSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXD.ColorScheme openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXD.ColorScheme openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
  }
  
  private static void SetName(DXD.ColorScheme openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Dark 1.
  /// </summary>
  private static DMD.ThemeColor? GetDark1Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Dark1Color>());
  }
  
  private static bool CmpDark1Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Dark1Color>(), value, diffs, objName, propName);
  }
  
  private static void SetDark1Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Dark1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Dark1Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  private static DMD.ThemeColor? GetLight1Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Light1Color>());
  }
  
  private static bool CmpLight1Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Light1Color>(), value, diffs, objName, propName);
  }
  
  private static void SetLight1Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Light1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Light1Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  private static DMD.ThemeColor? GetDark2Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Dark2Color>());
  }
  
  private static bool CmpDark2Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Dark2Color>(), value, diffs, objName, propName);
  }
  
  private static void SetDark2Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Dark2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Dark2Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  private static DMD.ThemeColor? GetLight2Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Light2Color>());
  }
  
  private static bool CmpLight2Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Light2Color>(), value, diffs, objName, propName);
  }
  
  private static void SetLight2Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Light2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Light2Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  private static DMD.ThemeColor? GetAccent1Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Accent1Color>());
  }
  
  private static bool CmpAccent1Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Accent1Color>(), value, diffs, objName, propName);
  }
  
  private static void SetAccent1Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Accent1Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Accent1Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  private static DMD.ThemeColor? GetAccent2Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Accent2Color>());
  }
  
  private static bool CmpAccent2Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Accent2Color>(), value, diffs, objName, propName);
  }
  
  private static void SetAccent2Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Accent2Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Accent2Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  private static DMD.ThemeColor? GetAccent3Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Accent3Color>());
  }
  
  private static bool CmpAccent3Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Accent3Color>(), value, diffs, objName, propName);
  }
  
  private static void SetAccent3Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Accent3Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Accent3Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  private static DMD.ThemeColor? GetAccent4Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Accent4Color>());
  }
  
  private static bool CmpAccent4Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Accent4Color>(), value, diffs, objName, propName);
  }
  
  private static void SetAccent4Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Accent4Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Accent4Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  private static DMD.ThemeColor? GetAccent5Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Accent5Color>());
  }
  
  private static bool CmpAccent5Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Accent5Color>(), value, diffs, objName, propName);
  }
  
  private static void SetAccent5Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Accent5Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Accent5Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  private static DMD.ThemeColor? GetAccent6Color(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Accent6Color>());
  }
  
  private static bool CmpAccent6Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Accent6Color>(), value, diffs, objName, propName);
  }
  
  private static void SetAccent6Color(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Accent6Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Accent6Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  private static DMD.ThemeColor? GetHyperlink(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.Hyperlink>());
  }
  
  private static bool CmpHyperlink(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Hyperlink>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlink(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  private static DMD.ThemeColor? GetFollowedHyperlinkColor(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ThemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.FollowedHyperlinkColor>());
  }
  
  private static bool CmpFollowedHyperlinkColor(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FollowedHyperlinkColor>(), value, diffs, objName, propName);
  }
  
  private static void SetFollowedHyperlinkColor(DXD.ColorScheme openXmlElement, DMD.ThemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FollowedHyperlinkColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeColorConverter.CreateOpenXmlElement<DXD.FollowedHyperlinkColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.ColorScheme openXmlElement)
  {
    return DMXD.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXD.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXD.ColorScheme openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.ColorScheme openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ColorScheme? CreateModelElement(DXD.ColorScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ColorScheme();
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
  
  public static bool CompareModelElement(DXD.ColorScheme? openXmlElement, DMD.ColorScheme? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpDark1Color(openXmlElement, value.Dark1Color, diffs, objName, propName))
        ok = false;
      if (!CmpLight1Color(openXmlElement, value.Light1Color, diffs, objName, propName))
        ok = false;
      if (!CmpDark2Color(openXmlElement, value.Dark2Color, diffs, objName, propName))
        ok = false;
      if (!CmpLight2Color(openXmlElement, value.Light2Color, diffs, objName, propName))
        ok = false;
      if (!CmpAccent1Color(openXmlElement, value.Accent1Color, diffs, objName, propName))
        ok = false;
      if (!CmpAccent2Color(openXmlElement, value.Accent2Color, diffs, objName, propName))
        ok = false;
      if (!CmpAccent3Color(openXmlElement, value.Accent3Color, diffs, objName, propName))
        ok = false;
      if (!CmpAccent4Color(openXmlElement, value.Accent4Color, diffs, objName, propName))
        ok = false;
      if (!CmpAccent5Color(openXmlElement, value.Accent5Color, diffs, objName, propName))
        ok = false;
      if (!CmpAccent6Color(openXmlElement, value.Accent6Color, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName, propName))
        ok = false;
      if (!CmpFollowedHyperlinkColor(openXmlElement, value.FollowedHyperlinkColor, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMD.ColorScheme? value)
    where OpenXmlElementType: DXD.ColorScheme, new()
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
