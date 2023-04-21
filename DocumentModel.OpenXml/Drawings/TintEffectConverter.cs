namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public static class TintEffectConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  private static Int32? GetHue(DXD.TintEffect openXmlElement)
  {
    return openXmlElement?.Hue?.Value;
  }
  
  private static bool CmpHue(DXD.TintEffect openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Hue?.Value == value) return true;
    diffs?.Add(objName, "Hue", openXmlElement?.Hue?.Value, value);
    return false;
  }
  
  private static void SetHue(DXD.TintEffect openXmlElement, Int32? value)
  {
    openXmlElement.Hue = value;
  }
  
  /// <summary>
  /// Amount
  /// </summary>
  private static Int32? GetAmount(DXD.TintEffect openXmlElement)
  {
    return openXmlElement?.Amount?.Value;
  }
  
  private static bool CmpAmount(DXD.TintEffect openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Amount?.Value == value) return true;
    diffs?.Add(objName, "Amount", openXmlElement?.Amount?.Value, value);
    return false;
  }
  
  private static void SetAmount(DXD.TintEffect openXmlElement, Int32? value)
  {
    openXmlElement.Amount = value;
  }
  
  public static DocumentModel.Drawings.TintEffect? CreateModelElement(DXD.TintEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TintEffect();
      value.Hue = GetHue(openXmlElement);
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.TintEffect? openXmlElement, DMD.TintEffect? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHue(openXmlElement, value.Hue, diffs, objName))
        ok = false;
      if (!CmpAmount(openXmlElement, value.Amount, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.TintEffect value)
    where OpenXmlElementType: DXD.TintEffect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.TintEffect openXmlElement, DMD.TintEffect value)
  {
    SetHue(openXmlElement, value?.Hue);
    SetAmount(openXmlElement, value?.Amount);
  }
}
