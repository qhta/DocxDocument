namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public static class StyleLabelConverter
{
  /// <summary>
  /// Style Name
  /// </summary>
  private static String? GetName(DXDrawDgms.StyleLabel openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDrawDgms.StyleLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXDrawDgms.StyleLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  private static DMDrawsDgms.Scene3D? GetScene3D(DXDrawDgms.StyleLabel openXmlElement)
  {
    return DMXDrawsDgms.Scene3DConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Scene3D>());
  }
  
  private static bool CmpScene3D(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Scene3D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.Scene3DConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Scene3D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScene3D(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.Scene3DConverter.CreateOpenXmlElement<DXDrawDgms.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  private static DMDrawsDgms.Shape3D? GetShape3D(DXDrawDgms.StyleLabel openXmlElement)
  {
    return DMXDrawsDgms.Shape3DConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Shape3D>());
  }
  
  private static bool CmpShape3D(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Shape3D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.Shape3DConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Shape3D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape3D(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Shape3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Shape3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.Shape3DConverter.CreateOpenXmlElement<DXDrawDgms.Shape3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  private static DMDrawsDgms.TextProperties? GetTextProperties(DXDrawDgms.StyleLabel openXmlElement)
  {
    return DMXDrawsDgms.TextPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextProperties>());
  }
  
  private static bool CmpTextProperties(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextProperties(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextPropertiesConverter.CreateOpenXmlElement<DXDrawDgms.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  private static DMDrawsDgms.Style? GetStyle(DXDrawDgms.StyleLabel openXmlElement)
  {
    return DMXDrawsDgms.StyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Style>());
  }
  
  private static bool CmpStyle(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Style? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.StyleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Style>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStyle(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Style? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.StyleConverter.CreateOpenXmlElement<DXDrawDgms.Style>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.StyleLabel openXmlElement)
  {
    return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.StyleLabel? CreateModelElement(DXDrawDgms.StyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.StyleLabel();
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
  
  public static bool CompareModelElement(DXDrawDgms.StyleLabel? openXmlElement, DMDrawsDgms.StyleLabel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpScene3D(openXmlElement, value.Scene3D, diffs, objName))
        ok = false;
      if (!CmpShape3D(openXmlElement, value.Shape3D, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleLabel? value)
    where OpenXmlElementType: DXDrawDgms.StyleLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetScene3D(openXmlElement, value?.Scene3D);
      SetShape3D(openXmlElement, value?.Shape3D);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetStyle(openXmlElement, value?.Style);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
