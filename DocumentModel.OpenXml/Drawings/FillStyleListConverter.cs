namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Fill Style List.
/// </summary>
public static class FillStyleListConverter
{
  private static Boolean? GetNoFill(DXDraw.FillStyleList openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXDraw.FillStyleList openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXDraw.FillStyleList openXmlElement, Boolean? value)
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
  
  private static DMDraws.SolidFill? GetSolidFill(DXDraw.FillStyleList openXmlElement)
  {
    return DMXDraws.SolidFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SolidFill>());
  }
  
  private static bool CmpSolidFill(DXDraw.FillStyleList openXmlElement, DMDraws.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SolidFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSolidFill(DXDraw.FillStyleList openXmlElement, DMDraws.SolidFill? value)
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
  
  private static DMDraws.GradientFill? GetGradientFill(DXDraw.FillStyleList openXmlElement)
  {
    return DMXDraws.GradientFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.GradientFill>());
  }
  
  private static bool CmpGradientFill(DXDraw.FillStyleList openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GradientFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientFill(DXDraw.FillStyleList openXmlElement, DMDraws.GradientFill? value)
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
  
  private static DMDraws.BlipFill? GetBlipFill(DXDraw.FillStyleList openXmlElement)
  {
    return DMXDraws.BlipFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BlipFill>());
  }
  
  private static bool CmpBlipFill(DXDraw.FillStyleList openXmlElement, DMDraws.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BlipFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlipFill(DXDraw.FillStyleList openXmlElement, DMDraws.BlipFill? value)
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
  
  private static DMDraws.PatternFill? GetPatternFill(DXDraw.FillStyleList openXmlElement)
  {
    return DMXDraws.PatternFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PatternFill>());
  }
  
  private static bool CmpPatternFill(DXDraw.FillStyleList openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PatternFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPatternFill(DXDraw.FillStyleList openXmlElement, DMDraws.PatternFill? value)
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
  
  private static Boolean? GetGroupFill(DXDraw.FillStyleList openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXDraw.FillStyleList openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.GroupFill", val, value);
    return false;
  }
  
  private static void SetGroupFill(DXDraw.FillStyleList openXmlElement, Boolean? value)
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
  
  public static DMDraws.FillStyleList? CreateModelElement(DXDraw.FillStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.FillStyleList();
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
  
  public static bool CompareModelElement(DXDraw.FillStyleList? openXmlElement, DMDraws.FillStyleList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.FillStyleList? value)
    where OpenXmlElementType: DXDraw.FillStyleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetGroupFill(openXmlElement, value?.GroupFill);
      return openXmlElement;
    }
    return default;
  }
}
