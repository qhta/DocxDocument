namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the StyleData Class.
/// </summary>
public static class StyleDataConverter
{
  private static DMDrawsDgms.DataModel? GetDataModel(DXDrawDgms.StyleData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.DataModel>();
    if (itemElement != null)
      return DMXDrawsDgms.DataModelConverter.CreateModelElement(itemElement);
    return null;
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
