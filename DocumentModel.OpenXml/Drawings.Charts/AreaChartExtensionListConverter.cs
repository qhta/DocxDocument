namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtensionList Class.
/// </summary>
public static class AreaChartExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.AreaChartExtension> GetAreaChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.AreaChartExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.AreaChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetAreaChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.AreaChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.AreaChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.AreaChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.AreaChartExtensionList();
      value.AreaChartExtensions = GetAreaChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.AreaChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaChartExtensions(openXmlElement, value?.AreaChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
