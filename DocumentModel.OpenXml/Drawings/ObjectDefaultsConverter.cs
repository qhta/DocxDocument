namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ObjectDefaults Class converter from/to OpenXml.
///</summary>
public static class ObjectDefaultsConverter
{
  /// <summary>
  /// Shape Default.
  /// </summary>
  private static DMDraws.ShapeDefault? GetShapeDefault(DXDraw.ObjectDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ShapeDefault>();
    if (element != null)
      return DMXDraws.ShapeDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.ShapeDefault? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapeDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ShapeDefault>(), value, diffs, objName);
  }
  
  private static void SetShapeDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.ShapeDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ShapeDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ShapeDefaultConverter.CreateOpenXmlElement<DXDraw.ShapeDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  private static DMDraws.LineDefault? GetLineDefault(DXDraw.ObjectDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.LineDefault>();
    if (element != null)
      return DMXDraws.LineDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.LineDefault? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LineDefault>(), value, diffs, objName);
  }
  
  private static void SetLineDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.LineDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineDefaultConverter.CreateOpenXmlElement<DXDraw.LineDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  private static DMDraws.TextDefault? GetTextDefault(DXDraw.ObjectDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.TextDefault>();
    if (element != null)
      return DMXDraws.TextDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.TextDefault? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.TextDefault>(), value, diffs, objName);
  }
  
  private static void SetTextDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.TextDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TextDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextDefaultConverter.CreateOpenXmlElement<DXDraw.TextDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.ObjectDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDraw.ObjectDefaults openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDraw.ObjectDefaults openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ObjectDefaults? CreateModelElement(DXDraw.ObjectDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ObjectDefaults();
      value.ShapeDefault = GetShapeDefault(openXmlElement);
      value.LineDefault = GetLineDefault(openXmlElement);
      value.TextDefault = GetTextDefault(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ObjectDefaults? openXmlElement, DMDraws.ObjectDefaults? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeDefault(openXmlElement, value.ShapeDefault, diffs, objName))
        ok = false;
      if (!CmpLineDefault(openXmlElement, value.LineDefault, diffs, objName))
        ok = false;
      if (!CmpTextDefault(openXmlElement, value.TextDefault, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ObjectDefaults value)
    where OpenXmlElementType: DXDraw.ObjectDefaults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ObjectDefaults openXmlElement, DMDraws.ObjectDefaults value)
  {
    SetShapeDefault(openXmlElement, value?.ShapeDefault);
    SetLineDefault(openXmlElement, value?.LineDefault);
    SetTextDefault(openXmlElement, value?.TextDefault);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
