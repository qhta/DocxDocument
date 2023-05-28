namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public static class ColorChangeConverter
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  private static Boolean? GetUseAlpha(DXD.ColorChange openXmlElement)
  {
    return openXmlElement?.UseAlpha?.Value;
  }
  
  private static bool CmpUseAlpha(DXD.ColorChange openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.UseAlpha?.Value == value) return true;
    diffs?.Add(objName, "UseAlpha", openXmlElement?.UseAlpha?.Value, value);
    return false;
  }
  
  private static void SetUseAlpha(DXD.ColorChange openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseAlpha = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseAlpha = null;
  }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  private static DMD.ColorFrom? GetColorFrom(DXD.ColorChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorFrom>();
    if (element != null)
      return DMXD.ColorFromConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorFrom(DXD.ColorChange openXmlElement, DMD.ColorFrom? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ColorFromConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorFrom>(), value, diffs, objName, propName);
  }
  
  private static void SetColorFrom(DXD.ColorChange openXmlElement, DMD.ColorFrom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorFrom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorFromConverter.CreateOpenXmlElement<DXD.ColorFrom>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  private static DMD.ColorTo? GetColorTo(DXD.ColorChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorTo>();
    if (element != null)
      return DMXD.ColorToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorTo(DXD.ColorChange openXmlElement, DMD.ColorTo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ColorToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorTo>(), value, diffs, objName, propName);
  }
  
  private static void SetColorTo(DXD.ColorChange openXmlElement, DMD.ColorTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorToConverter.CreateOpenXmlElement<DXD.ColorTo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ColorChange? CreateModelElement(DXD.ColorChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ColorChange();
      value.UseAlpha = GetUseAlpha(openXmlElement);
      value.ColorFrom = GetColorFrom(openXmlElement);
      value.ColorTo = GetColorTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ColorChange? openXmlElement, DMD.ColorChange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUseAlpha(openXmlElement, value.UseAlpha, diffs, objName, propName))
        ok = false;
      if (!CmpColorFrom(openXmlElement, value.ColorFrom, diffs, objName, propName))
        ok = false;
      if (!CmpColorTo(openXmlElement, value.ColorTo, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ColorChange value)
    where OpenXmlElementType: DXD.ColorChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ColorChange openXmlElement, DMD.ColorChange value)
  {
    SetUseAlpha(openXmlElement, value?.UseAlpha);
    SetColorFrom(openXmlElement, value?.ColorFrom);
    SetColorTo(openXmlElement, value?.ColorTo);
  }
}
