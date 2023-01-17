namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtensionList Class.
/// </summary>
public static class LineChartExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartExtension> GetLineChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.LineChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetLineChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.LineChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.LineChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineChartExtensionList();
      value.LineChartExtensions = GetLineChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LineChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineChartExtensions(openXmlElement, value?.LineChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
