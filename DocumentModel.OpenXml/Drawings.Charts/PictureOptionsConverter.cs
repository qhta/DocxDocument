namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public static class PictureOptionsConverter
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  private static Boolean? GetApplyToFront(DXDC.PictureOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ApplyToFront>() != null;
  }
  
  private static bool CmpApplyToFront(DXDC.PictureOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ApplyToFront>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ApplyToFront", val, value);
    return false;
  }
  
  private static void SetApplyToFront(DXDC.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ApplyToFront>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ApplyToFront();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  private static Boolean? GetApplyToSides(DXDC.PictureOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ApplyToSides>() != null;
  }
  
  private static bool CmpApplyToSides(DXDC.PictureOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ApplyToSides>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ApplyToSides", val, value);
    return false;
  }
  
  private static void SetApplyToSides(DXDC.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ApplyToSides>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ApplyToSides();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  private static Boolean? GetApplyToEnd(DXDC.PictureOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ApplyToEnd>() != null;
  }
  
  private static bool CmpApplyToEnd(DXDC.PictureOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ApplyToEnd>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ApplyToEnd", val, value);
    return false;
  }
  
  private static void SetApplyToEnd(DXDC.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ApplyToEnd>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ApplyToEnd();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  private static DMDC.PictureFormatKind? GetPictureFormat(DXDC.PictureOptions openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDC.PictureFormatKind>(openXmlElement.GetFirstChild<DXDC.PictureFormat>()?.Val?.Value);
  }
  
  private static bool CmpPictureFormat(DXDC.PictureOptions openXmlElement, DMDC.PictureFormatKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDC.PictureFormatKind>(openXmlElement.GetFirstChild<DXDC.PictureFormat>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetPictureFormat(DXDC.PictureOptions openXmlElement, DMDC.PictureFormatKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PictureFormat>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDC.PictureFormatKind>(itemElement, (DMDC.PictureFormatKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.PictureFormat, DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDC.PictureFormatKind>((DMDC.PictureFormatKind)value));
  }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  private static Double? GetPictureStackUnit(DXDC.PictureOptions openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PictureStackUnit>()?.Val);
  }
  
  private static bool CmpPictureStackUnit(DXDC.PictureOptions openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PictureStackUnit>()?.Val, value, diffs, objName, "PictureStackUnit");
  }
  
  private static void SetPictureStackUnit(DXDC.PictureOptions openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.PictureStackUnit,System.Double>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.Charts.PictureOptions? CreateModelElement(DXDC.PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PictureOptions();
      value.ApplyToFront = GetApplyToFront(openXmlElement);
      value.ApplyToSides = GetApplyToSides(openXmlElement);
      value.ApplyToEnd = GetApplyToEnd(openXmlElement);
      value.PictureFormat = GetPictureFormat(openXmlElement);
      value.PictureStackUnit = GetPictureStackUnit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.PictureOptions? openXmlElement, DMDC.PictureOptions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpApplyToFront(openXmlElement, value.ApplyToFront, diffs, objName))
        ok = false;
      if (!CmpApplyToSides(openXmlElement, value.ApplyToSides, diffs, objName))
        ok = false;
      if (!CmpApplyToEnd(openXmlElement, value.ApplyToEnd, diffs, objName))
        ok = false;
      if (!CmpPictureFormat(openXmlElement, value.PictureFormat, diffs, objName))
        ok = false;
      if (!CmpPictureStackUnit(openXmlElement, value.PictureStackUnit, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PictureOptions value)
    where OpenXmlElementType: DXDC.PictureOptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PictureOptions openXmlElement, DMDC.PictureOptions value)
  {
    SetApplyToFront(openXmlElement, value?.ApplyToFront);
    SetApplyToSides(openXmlElement, value?.ApplyToSides);
    SetApplyToEnd(openXmlElement, value?.ApplyToEnd);
    SetPictureFormat(openXmlElement, value?.PictureFormat);
    SetPictureStackUnit(openXmlElement, value?.PictureStackUnit);
  }
}
