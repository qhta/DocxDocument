namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Area3DChartExtensionList Class.
/// </summary>
public static class Area3DChartExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Area3DChartExtension>? GetArea3DChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Area3DChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.Area3DChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetArea3DChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Area3DChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.Area3DChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Area3DChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Area3DChartExtensionList();
      value.Area3DChartExtensions = GetArea3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Area3DChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
