namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public static class NumRefExtensionListConverter
{
  private static Collection<DMDrawsCharts.NumRefExtension> GetNumRefExtensions(DXDrawCharts.NumRefExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.NumRefExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.NumRefExtension>())
    {
      var newItem = DMXDrawsCharts.NumRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNumRefExtensions(DXDrawCharts.NumRefExtensionList openXmlElement, Collection<DMDrawsCharts.NumRefExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetNumRefExtensions(DXDrawCharts.NumRefExtensionList openXmlElement, Collection<DMDrawsCharts.NumRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.NumRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.NumRefExtensionConverter.CreateOpenXmlElement<DXDrawCharts.NumRefExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.NumRefExtensionList? CreateModelElement(DXDrawCharts.NumRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.NumRefExtensionList();
      value.NumRefExtensions = GetNumRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.NumRefExtensionList? openXmlElement, DMDrawsCharts.NumRefExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumRefExtensions(openXmlElement, value.NumRefExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumRefExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.NumRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumRefExtensions(openXmlElement, value?.NumRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}
