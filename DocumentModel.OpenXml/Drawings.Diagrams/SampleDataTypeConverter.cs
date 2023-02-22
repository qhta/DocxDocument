namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public static class SampleDataTypeConverter
{
  /// <summary>
  /// Use Default
  /// </summary>
  private static Boolean? GetUseDefault(DXDrawDgms.SampleDataType openXmlElement)
  {
    return openXmlElement?.UseDefault?.Value;
  }
  
  private static bool CmpUseDefault(DXDrawDgms.SampleDataType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UseDefault?.Value == value) return true;
    diffs?.Add(objName, "UseDefault", openXmlElement?.UseDefault?.Value, value);
    return false;
  }
  
  private static void SetUseDefault(DXDrawDgms.SampleDataType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseDefault = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseDefault = null;
  }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  private static DMDrawsDgms.DataModel? GetDataModel(DXDrawDgms.SampleDataType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.DataModel>();
    if (element != null)
      return DMXDrawsDgms.DataModelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataModel(DXDrawDgms.SampleDataType openXmlElement, DMDrawsDgms.DataModel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.DataModelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.DataModel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataModel(DXDrawDgms.SampleDataType openXmlElement, DMDrawsDgms.DataModel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.DataModel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.DataModelConverter.CreateOpenXmlElement<DXDrawDgms.DataModel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.SampleDataType? CreateModelElement(DXDrawDgms.SampleDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.SampleDataType();
      value.UseDefault = GetUseDefault(openXmlElement);
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.SampleDataType? openXmlElement, DMDrawsDgms.SampleDataType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUseDefault(openXmlElement, value.UseDefault, diffs, objName))
        ok = false;
      if (!CmpDataModel(openXmlElement, value.DataModel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.SampleDataType value)
    where OpenXmlElementType: DXDrawDgms.SampleDataType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.SampleDataType openXmlElement, DMDrawsDgms.SampleDataType value)
  {
    SetUseDefault(openXmlElement, value?.UseDefault);
    SetDataModel(openXmlElement, value?.DataModel);
    }
  }
