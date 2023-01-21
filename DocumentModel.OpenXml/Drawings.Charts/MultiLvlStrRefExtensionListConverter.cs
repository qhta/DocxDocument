namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public static class MultiLvlStrRefExtensionListConverter
{
  private static Collection<DMDrawsCharts.MultiLvlStrRefExtension> GetMultiLvlStrRefExtensions(DXDrawCharts.MultiLvlStrRefExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.MultiLvlStrRefExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.MultiLvlStrRefExtension>())
    {
      var newItem = DMXDrawsCharts.MultiLvlStrRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetMultiLvlStrRefExtensions(DXDrawCharts.MultiLvlStrRefExtensionList openXmlElement, Collection<DMDrawsCharts.MultiLvlStrRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.MultiLvlStrRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.MultiLvlStrRefExtensionConverter.CreateOpenXmlElement<DXDrawCharts.MultiLvlStrRefExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.MultiLvlStrRefExtensionList? CreateModelElement(DXDrawCharts.MultiLvlStrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.MultiLvlStrRefExtensionList();
      value.MultiLvlStrRefExtensions = GetMultiLvlStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.MultiLvlStrRefExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.MultiLvlStrRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLvlStrRefExtensions(openXmlElement, value?.MultiLvlStrRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}
