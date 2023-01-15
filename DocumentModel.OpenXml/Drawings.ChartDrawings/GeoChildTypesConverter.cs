using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildTypes Class.
/// </summary>
public static class GeoChildTypesConverter
{
  public static Collection<String>? GetEntityTypes(GeoChildTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<String>();
      foreach (var item in openXmlElement.Elements<EntityType>())
      {
        var newItem = StringValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((string)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetEntityTypes(GeoChildTypes? openXmlElement, Collection<String>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<EntityType>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<EntityType>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoChildTypes? CreateModelElement(GeoChildTypes? openXmlElement)
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
    where OpenXmlElementType : GeoChildTypes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityTypes(openXmlElement, value?.EntityTypes);
      return openXmlElement;
    }
    return default;
  }
}