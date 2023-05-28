namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the SampleData Class.
/// </summary>
public static class SampleDataConverter
{
  private static DMDD.DataModel? GetDataModel(DXDD.SampleData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.DataModel>();
    if (element != null)
      return DMXDD.DataModelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataModel(DXDD.SampleData openXmlElement, DMDD.DataModel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.DataModelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.DataModel>(), value, diffs, objName, propName);
  }
  
  private static void SetDataModel(DXDD.SampleData openXmlElement, DMDD.DataModel? value)
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
  
  public static DMDD.SampleData? CreateModelElement(DXDD.SampleData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.SampleData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.SampleData? openXmlElement, DMDD.SampleData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataModel(openXmlElement, value.DataModel, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.SampleData value)
    where OpenXmlElementType: DXDD.SampleData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.SampleData openXmlElement, DMDD.SampleData value)
  {
    SetDataModel(openXmlElement, value?.DataModel);
  }
}
