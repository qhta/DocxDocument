namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public static class ColorChangeConverter
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  private static Boolean? GetUseAlpha(DXDraw.ColorChange openXmlElement)
  {
    return openXmlElement?.UseAlpha?.Value;
  }
  
  private static bool CmpUseAlpha(DXDraw.ColorChange openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UseAlpha?.Value == value;
  }
  
  private static void SetUseAlpha(DXDraw.ColorChange openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseAlpha = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseAlpha = null;
  }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  private static DMDraws.ColorFrom? GetColorFrom(DXDraw.ColorChange openXmlElement)
  {
    return DMXDraws.ColorFromConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ColorFrom>());
  }
  
  private static bool CmpColorFrom(DXDraw.ColorChange openXmlElement, DMDraws.ColorFrom? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorFromConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorFrom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColorFrom(DXDraw.ColorChange openXmlElement, DMDraws.ColorFrom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorFrom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorFromConverter.CreateOpenXmlElement<DXDraw.ColorFrom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  private static DMDraws.ColorTo? GetColorTo(DXDraw.ColorChange openXmlElement)
  {
    return DMXDraws.ColorToConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ColorTo>());
  }
  
  private static bool CmpColorTo(DXDraw.ColorChange openXmlElement, DMDraws.ColorTo? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorTo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColorTo(DXDraw.ColorChange openXmlElement, DMDraws.ColorTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorToConverter.CreateOpenXmlElement<DXDraw.ColorTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ColorChange? CreateModelElement(DXDraw.ColorChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ColorChange();
      value.UseAlpha = GetUseAlpha(openXmlElement);
      value.ColorFrom = GetColorFrom(openXmlElement);
      value.ColorTo = GetColorTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ColorChange? openXmlElement, DMDraws.ColorChange? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUseAlpha(openXmlElement, value.UseAlpha, diffs, objName))
        ok = false;
      if (!CmpColorFrom(openXmlElement, value.ColorFrom, diffs, objName))
        ok = false;
      if (!CmpColorTo(openXmlElement, value.ColorTo, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ColorChange? value)
    where OpenXmlElementType: DXDraw.ColorChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUseAlpha(openXmlElement, value?.UseAlpha);
      SetColorFrom(openXmlElement, value?.ColorFrom);
      SetColorTo(openXmlElement, value?.ColorTo);
      return openXmlElement;
    }
    return default;
  }
}
