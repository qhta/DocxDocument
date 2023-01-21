namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the SampleData Class.
/// </summary>
public static class SampleDataConverter
{
  private static DMDrawsDgms.DataModel? GetDataModel(DXDrawDgms.SampleData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.DataModel>();
    if (itemElement != null)
      return DMXDrawsDgms.DataModelConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsDgms.SampleData? CreateModelElement(DXDrawDgms.SampleData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.SampleData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
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
