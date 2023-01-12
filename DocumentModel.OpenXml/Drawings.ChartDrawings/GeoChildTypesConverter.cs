namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildTypes Class.
/// </summary>
public static class GeoChildTypesConverter
{
  public static System.Collections.ObjectModel.Collection<String>? GetEntityTypes(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<String>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType>())
      {
        var newItem = StringValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((string)newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetEntityTypes(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes? openXmlElement, System.Collections.ObjectModel.Collection<String>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildTypes? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildTypes();
      value.EntityTypes = GetEntityTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoChildTypes? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
