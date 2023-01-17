namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtensionList Class.
/// </summary>
public static class BubbleChartExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleChartExtension> GetBubbleChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleChartExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.BubbleChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetBubbleChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.BubbleChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChartExtensionList();
      value.BubbleChartExtensions = GetBubbleChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBubbleChartExtensions(openXmlElement, value?.BubbleChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
