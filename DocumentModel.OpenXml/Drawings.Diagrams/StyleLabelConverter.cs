namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public static class StyleLabelConverter
{
  /// <summary>
  /// Style Name
  /// </summary>
  private static String? GetName(DXDD.StyleLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDD.StyleLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDD.StyleLabel openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  private static DMDD.Scene3D? GetScene3D(DXDD.StyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Scene3D>();
    if (element != null)
      return DMXDD.Scene3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3D(DXDD.StyleLabel openXmlElement, DMDD.Scene3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.Scene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Scene3D>(), value, diffs, objName, propName);
  }
  
  private static void SetScene3D(DXDD.StyleLabel openXmlElement, DMDD.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.Scene3DConverter.CreateOpenXmlElement<DXDD.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  private static DMDD.Shape3D? GetShape3D(DXDD.StyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Shape3D>();
    if (element != null)
      return DMXDD.Shape3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3D(DXDD.StyleLabel openXmlElement, DMDD.Shape3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.Shape3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Shape3D>(), value, diffs, objName, propName);
  }
  
  private static void SetShape3D(DXDD.StyleLabel openXmlElement, DMDD.Shape3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Shape3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.Shape3DConverter.CreateOpenXmlElement<DXDD.Shape3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  private static DMDD.TextProperties? GetTextProperties(DXDD.StyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.TextProperties>();
    if (element != null)
      return DMXDD.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDD.StyleLabel openXmlElement, DMDD.TextProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.TextProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTextProperties(DXDD.StyleLabel openXmlElement, DMDD.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.TextPropertiesConverter.CreateOpenXmlElement<DXDD.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  private static DMDD.Style? GetStyle(DXDD.StyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Style>();
    if (element != null)
      return DMXDD.StyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyle(DXDD.StyleLabel openXmlElement, DMDD.Style? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.StyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Style>(), value, diffs, objName, propName);
  }
  
  private static void SetStyle(DXDD.StyleLabel openXmlElement, DMDD.Style? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.StyleConverter.CreateOpenXmlElement<DXDD.Style>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDD.ExtensionList? GetExtensionList(DXDD.StyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.StyleLabel openXmlElement, DMDD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDD.StyleLabel openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.StyleLabel? CreateModelElement(DXDD.StyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.StyleLabel();
      value.Name = GetName(openXmlElement);
      value.Scene3D = GetScene3D(openXmlElement);
      value.Shape3D = GetShape3D(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.StyleLabel? openXmlElement, DMDD.StyleLabel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpScene3D(openXmlElement, value.Scene3D, diffs, objName, propName))
        ok = false;
      if (!CmpShape3D(openXmlElement, value.Shape3D, diffs, objName, propName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName, propName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.StyleLabel value)
    where OpenXmlElementType: DXDD.StyleLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.StyleLabel openXmlElement, DMDD.StyleLabel value)
  {
    SetName(openXmlElement, value?.Name);
    SetScene3D(openXmlElement, value?.Scene3D);
    SetShape3D(openXmlElement, value?.Shape3D);
    SetTextProperties(openXmlElement, value?.TextProperties);
    SetStyle(openXmlElement, value?.Style);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
