namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Data Class.
/// </summary>
public static class DataConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetId(DXO16DCD.Data openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO16DCD.Data openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO16DCD.Data openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  private static DMDCDs.NumericDimension? GetNumericDimension(DXO16DCD.Data openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.NumericDimension>();
    if (element != null)
      return DMXDCDs.NumericDimensionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumericDimension(DXO16DCD.Data openXmlElement, DMDCDs.NumericDimension? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.NumericDimensionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.NumericDimension>(), value, diffs, objName);
  }
  
  private static void SetNumericDimension(DXO16DCD.Data openXmlElement, DMDCDs.NumericDimension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.NumericDimension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.NumericDimensionConverter.CreateOpenXmlElement<DXO16DCD.NumericDimension>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.StringDimension? GetStringDimension(DXO16DCD.Data openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.StringDimension>();
    if (element != null)
      return DMXDCDs.StringDimensionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringDimension(DXO16DCD.Data openXmlElement, DMDCDs.StringDimension? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.StringDimensionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.StringDimension>(), value, diffs, objName);
  }
  
  private static void SetStringDimension(DXO16DCD.Data openXmlElement, DMDCDs.StringDimension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.StringDimension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.StringDimensionConverter.CreateOpenXmlElement<DXO16DCD.StringDimension>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.Data openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.Data openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.Data openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.Data? CreateModelElement(DXO16DCD.Data? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Data();
      value.Id = GetId(openXmlElement);
      value.NumericDimension = GetNumericDimension(openXmlElement);
      value.StringDimension = GetStringDimension(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.Data? openXmlElement, DMDCDs.Data? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpNumericDimension(openXmlElement, value.NumericDimension, diffs, objName))
        ok = false;
      if (!CmpStringDimension(openXmlElement, value.StringDimension, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Data value)
    where OpenXmlElementType: DXO16DCD.Data, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Data openXmlElement, DMDCDs.Data value)
  {
    SetId(openXmlElement, value?.Id);
    SetNumericDimension(openXmlElement, value?.NumericDimension);
    SetStringDimension(openXmlElement, value?.StringDimension);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
