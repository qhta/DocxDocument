namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public static class SampleDataTypeConverter
{
  /// <summary>
  /// Use Default
  /// </summary>
  private static Boolean? GetUseDefault(DXDD.SampleDataType openXmlElement)
  {
    return openXmlElement?.UseDefault?.Value;
  }
  
  private static bool CmpUseDefault(DXDD.SampleDataType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.UseDefault?.Value == value) return true;
    diffs?.Add(objName, "UseDefault", openXmlElement?.UseDefault?.Value, value);
    return false;
  }
  
  private static void SetUseDefault(DXDD.SampleDataType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseDefault = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseDefault = null;
  }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  private static DMDD.DataModel? GetDataModel(DXDD.SampleDataType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.DataModel>();
    if (element != null)
      return DMXDD.DataModelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataModel(DXDD.SampleDataType openXmlElement, DMDD.DataModel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.DataModelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.DataModel>(), value, diffs, objName, propName);
  }
  
  private static void SetDataModel(DXDD.SampleDataType openXmlElement, DMDD.DataModel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.DataModel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.DataModelConverter.CreateOpenXmlElement<DXDD.DataModel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.SampleDataType? CreateModelElement(DXDD.SampleDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.SampleDataType();
      value.UseDefault = GetUseDefault(openXmlElement);
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.SampleDataType? openXmlElement, DMDD.SampleDataType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUseDefault(openXmlElement, value.UseDefault, diffs, objName, propName))
        ok = false;
      if (!CmpDataModel(openXmlElement, value.DataModel, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.SampleDataType value)
    where OpenXmlElementType: DXDD.SampleDataType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.SampleDataType openXmlElement, DMDD.SampleDataType value)
  {
    SetUseDefault(openXmlElement, value?.UseDefault);
    SetDataModel(openXmlElement, value?.DataModel);
  }
}
