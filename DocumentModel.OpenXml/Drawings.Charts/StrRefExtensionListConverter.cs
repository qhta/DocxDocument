namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public static class StrRefExtensionListConverter
{
  private static Collection<DMDrawsCharts.StrRefExtension> GetStrRefExtensions(DXDrawCharts.StrRefExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StrRefExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StrRefExtension>())
    {
      var newItem = DMXDrawsCharts.StrRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetStrRefExtensions(DXDrawCharts.StrRefExtensionList openXmlElement, Collection<DMDrawsCharts.StrRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.StrRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.StrRefExtensionConverter.CreateOpenXmlElement<DXDrawCharts.StrRefExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.StrRefExtensionList? CreateModelElement(DXDrawCharts.StrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StrRefExtensionList();
      value.StrRefExtensions = GetStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StrRefExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.StrRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStrRefExtensions(openXmlElement, value?.StrRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}
