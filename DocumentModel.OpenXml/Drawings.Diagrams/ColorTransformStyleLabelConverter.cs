namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public static class ColorTransformStyleLabelConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDD.ColorTransformStyleLabel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDD.ColorTransformStyleLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDD.ColorTransformStyleLabel openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Color List.
  /// </summary>
  private static DMDD.FillColorList? GetFillColorList(DXDD.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.FillColorList>();
    if (element != null)
      return DMXDD.FillColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.FillColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.FillColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.FillColorList>(), value, diffs, objName);
  }
  
  private static void SetFillColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.FillColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.FillColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.FillColorListConverter.CreateOpenXmlElement<DXDD.FillColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  private static DMDD.LineColorList? GetLineColorList(DXDD.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.LineColorList>();
    if (element != null)
      return DMXDD.LineColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.LineColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.LineColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.LineColorList>(), value, diffs, objName);
  }
  
  private static void SetLineColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.LineColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.LineColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.LineColorListConverter.CreateOpenXmlElement<DXDD.LineColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  private static DMDD.EffectColorList? GetEffectColorList(DXDD.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.EffectColorList>();
    if (element != null)
      return DMXDD.EffectColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.EffectColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.EffectColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.EffectColorList>(), value, diffs, objName);
  }
  
  private static void SetEffectColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.EffectColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.EffectColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.EffectColorListConverter.CreateOpenXmlElement<DXDD.EffectColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  private static DMDD.TextLineColorList? GetTextLineColorList(DXDD.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.TextLineColorList>();
    if (element != null)
      return DMXDD.TextLineColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextLineColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.TextLineColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.TextLineColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.TextLineColorList>(), value, diffs, objName);
  }
  
  private static void SetTextLineColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.TextLineColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.TextLineColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.TextLineColorListConverter.CreateOpenXmlElement<DXDD.TextLineColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  private static DMDD.TextFillColorList? GetTextFillColorList(DXDD.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.TextFillColorList>();
    if (element != null)
      return DMXDD.TextFillColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextFillColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.TextFillColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.TextFillColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.TextFillColorList>(), value, diffs, objName);
  }
  
  private static void SetTextFillColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.TextFillColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.TextFillColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.TextFillColorListConverter.CreateOpenXmlElement<DXDD.TextFillColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  private static DMDD.TextEffectColorList? GetTextEffectColorList(DXDD.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.TextEffectColorList>();
    if (element != null)
      return DMXDD.TextEffectColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextEffectColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.TextEffectColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.TextEffectColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.TextEffectColorList>(), value, diffs, objName);
  }
  
  private static void SetTextEffectColorList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.TextEffectColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.TextEffectColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.TextEffectColorListConverter.CreateOpenXmlElement<DXDD.TextEffectColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDD.ExtensionList? GetExtensionList(DXDD.ColorTransformStyleLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel? CreateModelElement(DXDD.ColorTransformStyleLabel? openXmlElement)
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
  
  public static bool CompareModelElement(DXDD.ColorTransformStyleLabel? openXmlElement, DMDD.ColorTransformStyleLabel? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.ColorTransformStyleLabel value)
    where OpenXmlElementType: DXDD.ColorTransformStyleLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.ColorTransformStyleLabel openXmlElement, DMDD.ColorTransformStyleLabel value)
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
