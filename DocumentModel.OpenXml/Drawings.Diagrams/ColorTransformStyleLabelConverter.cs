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
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDrawDgms.ColorTransformStyleLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXDrawDgms.ColorTransformStyleLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Fill Color List.
  /// </summary>
  private static DMDrawsDgms.FillColorList? GetFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    return DMXDrawsDgms.FillColorListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.FillColorList>());
  }
  
  private static bool CmpFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.FillColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.FillColorListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.FillColorList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.LineColorListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.LineColorList>());
  }
  
  private static bool CmpLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.LineColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.LineColorListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.LineColorList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.EffectColorListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.EffectColorList>());
  }
  
  private static bool CmpEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.EffectColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.EffectColorListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.EffectColorList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.TextLineColorListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextLineColorList>());
  }
  
  private static bool CmpTextLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextLineColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextLineColorListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextLineColorList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.TextFillColorListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextFillColorList>());
  }
  
  private static bool CmpTextFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextFillColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextFillColorListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextFillColorList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.TextEffectColorListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextEffectColorList>());
  }
  
  private static bool CmpTextEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextEffectColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextEffectColorListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextEffectColorList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsDgms.ColorTransformStyleLabel? CreateModelElement(DXDrawDgms.ColorTransformStyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ColorTransformStyleLabel();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorTransformStyleLabel? value)
    where OpenXmlElementType: DXDrawDgms.ColorTransformStyleLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetFillColorList(openXmlElement, value?.FillColorList);
      SetLineColorList(openXmlElement, value?.LineColorList);
      SetEffectColorList(openXmlElement, value?.EffectColorList);
      SetTextLineColorList(openXmlElement, value?.TextLineColorList);
      SetTextFillColorList(openXmlElement, value?.TextFillColorList);
      SetTextEffectColorList(openXmlElement, value?.TextEffectColorList);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
