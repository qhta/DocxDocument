namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public static class ChartSpaceExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ChartSpaceExtension> GetChartSpaceExtensions(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ChartSpaceExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.ChartSpaceExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetChartSpaceExtensions(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ChartSpaceExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.ChartSpaceExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartSpaceExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpaceExtensionList();
      value.ChartSpaceExtensions = GetChartSpaceExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartSpaceExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartSpaceExtensions(openXmlElement, value?.ChartSpaceExtensions);
      return openXmlElement;
    }
    return default;
  }
}
