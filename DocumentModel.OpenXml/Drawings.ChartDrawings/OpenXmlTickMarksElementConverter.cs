namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public static class OpenXmlTickMarksElementConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.TickMarksType? GetType(DXO16DCD.OpenXmlTickMarksElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType, DMDCDs.TickMarksType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXO16DCD.OpenXmlTickMarksElement openXmlElement, DMDCDs.TickMarksType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType, DMDCDs.TickMarksType>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXO16DCD.OpenXmlTickMarksElement openXmlElement, DMDCDs.TickMarksType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType, DMDCDs.TickMarksType>(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.OpenXmlTickMarksElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.OpenXmlTickMarksElement openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO16DCD.OpenXmlTickMarksElement openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.OpenXmlTickMarksElement? CreateModelElement(DXO16DCD.OpenXmlTickMarksElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.OpenXmlTickMarksElement();
      value.Type = GetType(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.OpenXmlTickMarksElement? openXmlElement, DMDCDs.OpenXmlTickMarksElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.OpenXmlTickMarksElement value)
    where OpenXmlElementType: DXO16DCD.OpenXmlTickMarksElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.OpenXmlTickMarksElement openXmlElement, DMDCDs.OpenXmlTickMarksElement value)
  {
    SetType(openXmlElement, value?.Type);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
