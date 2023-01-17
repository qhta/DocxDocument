namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtensionList Class.
/// </summary>
public static class Pie3DChartExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Pie3DChartExtension> GetPie3DChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Pie3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.Pie3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPie3DChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Pie3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.Pie3DChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Pie3DChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Pie3DChartExtensionList();
      value.Pie3DChartExtensions = GetPie3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Pie3DChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPie3DChartExtensions(openXmlElement, value?.Pie3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
