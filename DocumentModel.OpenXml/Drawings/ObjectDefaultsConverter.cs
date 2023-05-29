namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
public static class ObjectDefaultsConverter
{
  /// <summary>
  /// Shape Default.
  /// </summary>
  private static DMD.ShapeDefault? GetShapeDefault(DXD.ObjectDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapeDefault>();
    if (element != null)
      return DMXD.ShapeDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeDefault(DXD.ObjectDefaults openXmlElement, DMD.ShapeDefault? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ShapeDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapeDefault>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeDefault(DXD.ObjectDefaults openXmlElement, DMD.ShapeDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ShapeDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ShapeDefaultConverter.CreateOpenXmlElement<DXD.ShapeDefault>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  private static DMD.LineDefault? GetLineDefault(DXD.ObjectDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LineDefault>();
    if (element != null)
      return DMXD.LineDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineDefault(DXD.ObjectDefaults openXmlElement, DMD.LineDefault? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LineDefault>(), value, diffs, objName, propName);
  }
  
  private static void SetLineDefault(DXD.ObjectDefaults openXmlElement, DMD.LineDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LineDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineDefaultConverter.CreateOpenXmlElement<DXD.LineDefault>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  private static DMD.TextDefault? GetTextDefault(DXD.ObjectDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TextDefault>();
    if (element != null)
      return DMXD.TextDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextDefault(DXD.ObjectDefaults openXmlElement, DMD.TextDefault? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TextDefault>(), value, diffs, objName, propName);
  }
  
  private static void SetTextDefault(DXD.ObjectDefaults openXmlElement, DMD.TextDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TextDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextDefaultConverter.CreateOpenXmlElement<DXD.TextDefault>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.ObjectDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.ObjectDefaults openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.ObjectDefaults openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ObjectDefaults? CreateModelElement(DXD.ObjectDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ObjectDefaults();
      value.ShapeDefault = GetShapeDefault(openXmlElement);
      value.LineDefault = GetLineDefault(openXmlElement);
      value.TextDefault = GetTextDefault(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ObjectDefaults? openXmlElement, DMD.ObjectDefaults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeDefault(openXmlElement, value.ShapeDefault, diffs, objName, propName))
        ok = false;
      if (!CmpLineDefault(openXmlElement, value.LineDefault, diffs, objName, propName))
        ok = false;
      if (!CmpTextDefault(openXmlElement, value.TextDefault, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ObjectDefaults value)
    where OpenXmlElementType: DXD.ObjectDefaults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ObjectDefaults openXmlElement, DMD.ObjectDefaults value)
  {
    SetShapeDefault(openXmlElement, value?.ShapeDefault);
    SetLineDefault(openXmlElement, value?.LineDefault);
    SetTextDefault(openXmlElement, value?.TextDefault);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
