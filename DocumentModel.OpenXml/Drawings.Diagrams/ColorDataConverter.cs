namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the ColorData Class.
/// </summary>
public static class ColorDataConverter
{
  private static DMDrawsDgms.DataModel? GetDataModel(DXDrawDgms.ColorData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.DataModel>();
    if (itemElement != null)
      return DMXDrawsDgms.DataModelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataModel(DXDrawDgms.ColorData openXmlElement, DMDrawsDgms.DataModel? value)
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
  
  public static DMDrawsDgms.ColorData? CreateModelElement(DXDrawDgms.ColorData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ColorData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorData? value)
    where OpenXmlElementType: DXDrawDgms.ColorData, new()
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
