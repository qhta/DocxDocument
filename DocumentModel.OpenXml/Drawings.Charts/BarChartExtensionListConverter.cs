namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtensionList Class.
/// </summary>
public static class BarChartExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BarChartExtension>? GetBarChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BarChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.BarChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetBarChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BarChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.BarChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartExtensionList();
      value.BarChartExtensions = GetBarChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BarChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
