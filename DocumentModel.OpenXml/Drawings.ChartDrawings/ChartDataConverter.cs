namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public static class ChartDataConverter
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  private static DMDCDs.ExternalData? GetExternalData(DXO16DCD.ChartData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExternalData>();
    if (element != null)
      return DMXDCDs.ExternalDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExternalData(DXO16DCD.ChartData openXmlElement, DMDCDs.ExternalData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExternalDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExternalData>(), value, diffs, objName, propName);
  }
  
  private static void SetExternalData(DXO16DCD.ChartData openXmlElement, DMDCDs.ExternalData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExternalData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExternalDataConverter.CreateOpenXmlElement<DXO16DCD.ExternalData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.Data? GetData(DXO16DCD.ChartData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Data>();
    if (element != null)
      return DMXDCDs.DataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpData(DXO16DCD.ChartData openXmlElement, DMDCDs.Data? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.DataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Data>(), value, diffs, objName, propName);
  }
  
  private static void SetData(DXO16DCD.ChartData openXmlElement, DMDCDs.Data? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Data>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.DataConverter.CreateOpenXmlElement<DXO16DCD.Data>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.ChartData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.ChartData openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO16DCD.ChartData openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.ChartData? CreateModelElement(DXO16DCD.ChartData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartData();
      value.ExternalData = GetExternalData(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ChartData? openXmlElement, DMDCDs.ChartData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExternalData(openXmlElement, value.ExternalData, diffs, objName, propName))
        ok = false;
      if (!CmpData(openXmlElement, value.Data, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ChartData value)
    where OpenXmlElementType: DXO16DCD.ChartData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ChartData openXmlElement, DMDCDs.ChartData value)
  {
    SetExternalData(openXmlElement, value?.ExternalData);
    SetData(openXmlElement, value?.Data);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
