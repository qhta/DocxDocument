namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public static class SurfaceChartExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SurfaceChartExtension>? GetSurfaceChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SurfaceChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.SurfaceChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetSurfaceChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SurfaceChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.SurfaceChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChartExtensionList();
      value.SurfaceChartExtensions = GetSurfaceChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SurfaceChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
