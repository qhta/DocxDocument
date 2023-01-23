namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the StyleData Class.
/// </summary>
public static class StyleDataConverter
{
  private static DMDrawsDgms.DataModel? GetDataModel(DXDrawDgms.StyleData openXmlElement)
  {
    return DMXDrawsDgms.DataModelConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.DataModel>());
  }
  
  private static bool CmpDataModel(DXDrawDgms.StyleData openXmlElement, DMDrawsDgms.DataModel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.DataModelConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.DataModel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataModel(DXDrawDgms.StyleData openXmlElement, DMDrawsDgms.DataModel? value)
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
  
  public static DMDrawsDgms.StyleData? CreateModelElement(DXDrawDgms.StyleData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.StyleData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.StyleData? openXmlElement, DMDrawsDgms.StyleData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataModel(openXmlElement, value.DataModel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleData? value)
    where OpenXmlElementType: DXDrawDgms.StyleData, new()
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
