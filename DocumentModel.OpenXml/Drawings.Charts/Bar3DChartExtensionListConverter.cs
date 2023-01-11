namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtensionList Class.
/// </summary>
public static class Bar3DChartExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Bar3DChartExtension>? GetBar3DChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Bar3DChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.Bar3DChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetBar3DChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Bar3DChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.Bar3DChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Bar3DChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Bar3DChartExtensionList();
      value.Bar3DChartExtensions = GetBar3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Bar3DChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
