namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Underline Fill.
/// </summary>
public static class UnderlineFillConverter
{
  /// <summary>
  /// NoFill.
  /// </summary>
  private static Boolean? GetNoFill(DXDraw.UnderlineFill openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXDraw.UnderlineFill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXDraw.UnderlineFill openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.NoFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  private static DMDraws.SolidFill? GetSolidFill(DXDraw.UnderlineFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SolidFill>();
    if (element != null)
      return DMXDraws.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXDraw.UnderlineFill openXmlElement, DMDraws.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SolidFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSolidFill(DXDraw.UnderlineFill openXmlElement, DMDraws.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SolidFillConverter.CreateOpenXmlElement<DXDraw.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  private static DMDraws.GradientFill? GetGradientFill(DXDraw.UnderlineFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.GradientFill>();
    if (element != null)
      return DMXDraws.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXDraw.UnderlineFill openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GradientFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientFill(DXDraw.UnderlineFill openXmlElement, DMDraws.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GradientFillConverter.CreateOpenXmlElement<DXDraw.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  private static DMDraws.BlipFill? GetBlipFill(DXDraw.UnderlineFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BlipFill>();
    if (element != null)
      return DMXDraws.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXDraw.UnderlineFill openXmlElement, DMDraws.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BlipFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlipFill(DXDraw.UnderlineFill openXmlElement, DMDraws.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlipFillConverter.CreateOpenXmlElement<DXDraw.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  private static DMDraws.PatternFill? GetPatternFill(DXDraw.UnderlineFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PatternFill>();
    if (element != null)
      return DMXDraws.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXDraw.UnderlineFill openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PatternFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPatternFill(DXDraw.UnderlineFill openXmlElement, DMDraws.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PatternFillConverter.CreateOpenXmlElement<DXDraw.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  private static Boolean? GetGroupFill(DXDraw.UnderlineFill openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXDraw.UnderlineFill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.GroupFill", val, value);
    return false;
  }
  
  private static void SetGroupFill(DXDraw.UnderlineFill openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.GroupFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.UnderlineFill? CreateModelElement(DXDraw.UnderlineFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.UnderlineFill();
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.UnderlineFill? openXmlElement, DMDraws.UnderlineFill? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoFill(openXmlElement, value.NoFill, diffs, objName))
        ok = false;
      if (!CmpSolidFill(openXmlElement, value.SolidFill, diffs, objName))
        ok = false;
      if (!CmpGradientFill(openXmlElement, value.GradientFill, diffs, objName))
        ok = false;
      if (!CmpBlipFill(openXmlElement, value.BlipFill, diffs, objName))
        ok = false;
      if (!CmpPatternFill(openXmlElement, value.PatternFill, diffs, objName))
        ok = false;
      if (!CmpGroupFill(openXmlElement, value.GroupFill, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.UnderlineFill value)
    where OpenXmlElementType: DXDraw.UnderlineFill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.UnderlineFill openXmlElement, DMDraws.UnderlineFill value)
  {
    SetNoFill(openXmlElement, value?.NoFill);
    SetSolidFill(openXmlElement, value?.SolidFill);
    SetGradientFill(openXmlElement, value?.GradientFill);
    SetBlipFill(openXmlElement, value?.BlipFill);
    SetPatternFill(openXmlElement, value?.PatternFill);
    SetGroupFill(openXmlElement, value?.GroupFill);
  }
}
