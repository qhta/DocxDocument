namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtensionList Class.
/// </summary>
public static class Surface3DChartExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Surface3DChartExtension>? GetSurface3DChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Surface3DChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.Surface3DChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetSurface3DChartExtensions(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Surface3DChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.Surface3DChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Surface3DChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Surface3DChartExtensionList();
      value.Surface3DChartExtensions = GetSurface3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Surface3DChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurface3DChartExtensions(openXmlElement, value?.Surface3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
