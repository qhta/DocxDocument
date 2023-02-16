namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the SampleData Class.
/// </summary>
public static class SampleDataConverter
{
  private static DMDrawsDgms.DataModel? GetDataModel(DXDrawDgms.SampleData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.DataModel>();
    if (element != null)
      return DMXDrawsDgms.DataModelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataModel(DXDrawDgms.SampleData openXmlElement, DMDrawsDgms.DataModel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.DataModelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.DataModel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataModel(DXDrawDgms.SampleData openXmlElement, DMDrawsDgms.DataModel? value)
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
  
  public static DocumentModel.Drawings.Diagrams.SampleData? CreateModelElement(DXDrawDgms.SampleData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.SampleData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.SampleData? openXmlElement, DMDrawsDgms.SampleData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataModel(openXmlElement, value.DataModel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.SampleData? value)
    where OpenXmlElementType: DXDrawDgms.SampleData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataModel(openXmlElement, value?.DataModel);
      return openXmlElement;
    }
    return default;
  }
}
