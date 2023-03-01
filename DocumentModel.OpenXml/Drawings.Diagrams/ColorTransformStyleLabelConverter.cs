namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public static class ColorTransformStyleLabelConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDrawDgms.ColorTransformStyleLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDrawDgms.ColorTransformStyleLabel openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Color List.
  /// </summary>
  private static DMDrawsDgms.FillColorList? GetFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.FillColorList>();
    if (element != null)
      return DMXDrawsDgms.FillColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.FillColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.FillColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.FillColorList>(), value, diffs, objName);
  }
  
  private static void SetFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.FillColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.FillColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.FillColorListConverter.CreateOpenXmlElement<DXDrawDgms.FillColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  private static DMDrawsDgms.LineColorList? GetLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.LineColorList>();
    if (element != null)
      return DMXDrawsDgms.LineColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.LineColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.LineColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.LineColorList>(), value, diffs, objName);
  }
  
  private static void SetLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.LineColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.LineColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.LineColorListConverter.CreateOpenXmlElement<DXDrawDgms.LineColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  private static DMDrawsDgms.EffectColorList? GetEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.EffectColorList>();
    if (element != null)
      return DMXDrawsDgms.EffectColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.EffectColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.EffectColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.EffectColorList>(), value, diffs, objName);
  }
  
  private static void SetEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.EffectColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.EffectColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.EffectColorListConverter.CreateOpenXmlElement<DXDrawDgms.EffectColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  private static DMDrawsDgms.TextLineColorList? GetTextLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.TextLineColorList>();
    if (element != null)
      return DMXDrawsDgms.TextLineColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextLineColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextLineColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.TextLineColorList>(), value, diffs, objName);
  }
  
  private static void SetTextLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextLineColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextLineColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextLineColorListConverter.CreateOpenXmlElement<DXDrawDgms.TextLineColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  private static DMDrawsDgms.TextFillColorList? GetTextFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.TextFillColorList>();
    if (element != null)
      return DMXDrawsDgms.TextFillColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextFillColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextFillColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.TextFillColorList>(), value, diffs, objName);
  }
  
  private static void SetTextFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextFillColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextFillColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextFillColorListConverter.CreateOpenXmlElement<DXDrawDgms.TextFillColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  private static DMDrawsDgms.TextEffectColorList? GetTextEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.TextEffectColorList>();
    if (element != null)
      return DMXDrawsDgms.TextEffectColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextEffectColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextEffectColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.TextEffectColorList>(), value, diffs, objName);
  }
  
  private static void SetTextEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextEffectColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextEffectColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextEffectColorListConverter.CreateOpenXmlElement<DXDrawDgms.TextEffectColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (element != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel? CreateModelElement(DXDrawDgms.ColorTransformStyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel();
      value.Name = GetName(openXmlElement);
      value.FillColorList = GetFillColorList(openXmlElement);
      value.LineColorList = GetLineColorList(openXmlElement);
      value.EffectColorList = GetEffectColorList(openXmlElement);
      value.TextLineColorList = GetTextLineColorList(openXmlElement);
      value.TextFillColorList = GetTextFillColorList(openXmlElement);
      value.TextEffectColorList = GetTextEffectColorList(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.ColorTransformStyleLabel? openXmlElement, DMDrawsDgms.ColorTransformStyleLabel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpFillColorList(openXmlElement, value.FillColorList, diffs, objName))
        ok = false;
      if (!CmpLineColorList(openXmlElement, value.LineColorList, diffs, objName))
        ok = false;
      if (!CmpEffectColorList(openXmlElement, value.EffectColorList, diffs, objName))
        ok = false;
      if (!CmpTextLineColorList(openXmlElement, value.TextLineColorList, diffs, objName))
        ok = false;
      if (!CmpTextFillColorList(openXmlElement, value.TextFillColorList, diffs, objName))
        ok = false;
      if (!CmpTextEffectColorList(openXmlElement, value.TextEffectColorList, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorTransformStyleLabel value)
    where OpenXmlElementType: DXDrawDgms.ColorTransformStyleLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.ColorTransformStyleLabel value)
  {
    SetName(openXmlElement, value?.Name);
    SetFillColorList(openXmlElement, value?.FillColorList);
    SetLineColorList(openXmlElement, value?.LineColorList);
    SetEffectColorList(openXmlElement, value?.EffectColorList);
    SetTextLineColorList(openXmlElement, value?.TextLineColorList);
    SetTextFillColorList(openXmlElement, value?.TextFillColorList);
    SetTextEffectColorList(openXmlElement, value?.TextEffectColorList);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
