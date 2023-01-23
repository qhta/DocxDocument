namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public static class PictureOptionsConverter
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  private static Boolean? GetApplyToFront(DXDrawCharts.PictureOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ApplyToFront>() != null;
  }
  
  private static bool CmpApplyToFront(DXDrawCharts.PictureOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ApplyToFront>() != null == value;
  }
  
  private static void SetApplyToFront(DXDrawCharts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToFront>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ApplyToFront();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  private static Boolean? GetApplyToSides(DXDrawCharts.PictureOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ApplyToSides>() != null;
  }
  
  private static bool CmpApplyToSides(DXDrawCharts.PictureOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ApplyToSides>() != null == value;
  }
  
  private static void SetApplyToSides(DXDrawCharts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToSides>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ApplyToSides();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  private static Boolean? GetApplyToEnd(DXDrawCharts.PictureOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ApplyToEnd>() != null;
  }
  
  private static bool CmpApplyToEnd(DXDrawCharts.PictureOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ApplyToEnd>() != null == value;
  }
  
  private static void SetApplyToEnd(DXDrawCharts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToEnd>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ApplyToEnd();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  private static DMDrawsCharts.PictureFormatKind? GetPictureFormat(DXDrawCharts.PictureOptions openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDrawsCharts.PictureFormatKind>(openXmlElement.GetFirstChild<DXDrawCharts.PictureFormat>()?.Val?.Value);
  }
  
  private static bool CmpPictureFormat(DXDrawCharts.PictureOptions openXmlElement, DMDrawsCharts.PictureFormatKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDrawsCharts.PictureFormatKind>(openXmlElement.GetFirstChild<DXDrawCharts.PictureFormat>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPictureFormat(DXDrawCharts.PictureOptions openXmlElement, DMDrawsCharts.PictureFormatKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PictureFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.PictureFormat, DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDrawsCharts.PictureFormatKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  private static Double? GetPictureStackUnit(DXDrawCharts.PictureOptions openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.PictureStackUnit>()?.Val?.Value;
  }
  
  private static bool CmpPictureStackUnit(DXDrawCharts.PictureOptions openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.PictureStackUnit>()?.Val?.Value == value;
  }
  
  private static void SetPictureStackUnit(DXDrawCharts.PictureOptions openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PictureStackUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.PictureStackUnit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.PictureOptions? CreateModelElement(DXDrawCharts.PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PictureOptions();
      value.ApplyToFront = GetApplyToFront(openXmlElement);
      value.ApplyToSides = GetApplyToSides(openXmlElement);
      value.ApplyToEnd = GetApplyToEnd(openXmlElement);
      value.PictureFormat = GetPictureFormat(openXmlElement);
      value.PictureStackUnit = GetPictureStackUnit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.PictureOptions? openXmlElement, DMDrawsCharts.PictureOptions? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PictureOptions? value)
    where OpenXmlElementType: DXDrawCharts.PictureOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetApplyToFront(openXmlElement, value?.ApplyToFront);
      SetApplyToSides(openXmlElement, value?.ApplyToSides);
      SetApplyToEnd(openXmlElement, value?.ApplyToEnd);
      SetPictureFormat(openXmlElement, value?.PictureFormat);
      SetPictureStackUnit(openXmlElement, value?.PictureStackUnit);
      return openXmlElement;
    }
    return default;
  }
}
