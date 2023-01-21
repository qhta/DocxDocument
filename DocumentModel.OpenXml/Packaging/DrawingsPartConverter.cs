namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DrawingsPart
/// </summary>
public static class DrawingsPartConverter
{
  /// <summary>
  /// Gets the ChartParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.ChartPart> GetChartParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.ChartPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ChartPart>())
    {
      var newItem = DMXPack.ChartPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static String? GetContentType(DXPack.DrawingsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.CustomXmlPart> GetCustomXmlParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.CustomXmlPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.CustomXmlPart>())
    {
      var newItem = DMXPack.CustomXmlPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.DiagramColorsPart> GetDiagramColorsParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.DiagramColorsPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.DiagramColorsPart>())
    {
      var newItem = DMXPack.DiagramColorsPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.DiagramDataPart> GetDiagramDataParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.DiagramDataPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.DiagramDataPart>())
    {
      var newItem = DMXPack.DiagramDataPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.DiagramLayoutDefinitionPart> GetDiagramLayoutDefinitionParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.DiagramLayoutDefinitionPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.DiagramLayoutDefinitionPart>())
    {
      var newItem = DMXPack.DiagramLayoutDefinitionPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.DiagramPersistLayoutPart> GetDiagramPersistLayoutParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.DiagramPersistLayoutPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.DiagramPersistLayoutPart>())
    {
      var newItem = DMXPack.DiagramPersistLayoutPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.DiagramStylePart> GetDiagramStyleParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.DiagramStylePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.DiagramStylePart>())
    {
      var newItem = DMXPack.DiagramStylePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.ExtendedChartPart> GetExtendedChartParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.ExtendedChartPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ExtendedChartPart>())
    {
      var newItem = DMXPack.ExtendedChartPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.ImagePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ImagePart>())
    {
      var newItem = DMXPack.ImagePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static String? GetRelationshipType(DXPack.DrawingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the DrawingsPart
  /// </summary>
  private static Collection<DMPack.WebExtensionPart> GetWebExtensionParts(DXPack.DrawingsPart openXmlElement)
  {
    var collection = new Collection<DMPack.WebExtensionPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.WebExtensionPart>())
    {
      var newItem = DMXPack.WebExtensionPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  public static DMPack.DrawingsPart? CreateModelElement(DXPack.DrawingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DrawingsPart();
      value.ChartParts = GetChartParts(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.CustomXmlParts = GetCustomXmlParts(openXmlElement);
      value.DiagramColorsParts = GetDiagramColorsParts(openXmlElement);
      value.DiagramDataParts = GetDiagramDataParts(openXmlElement);
      value.DiagramLayoutDefinitionParts = GetDiagramLayoutDefinitionParts(openXmlElement);
      value.DiagramPersistLayoutParts = GetDiagramPersistLayoutParts(openXmlElement);
      value.DiagramStyleParts = GetDiagramStyleParts(openXmlElement);
      value.ExtendedChartParts = GetExtendedChartParts(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WebExtensionParts = GetWebExtensionParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DrawingsPart? value)
    where OpenXmlElementType: DXPack.DrawingsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetChartParts(openXmlElement, value?.ChartParts);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetCustomXmlParts(openXmlElement, value?.CustomXmlParts);
      //SetDiagramColorsParts(openXmlElement, value?.DiagramColorsParts);
      //SetDiagramDataParts(openXmlElement, value?.DiagramDataParts);
      //SetDiagramLayoutDefinitionParts(openXmlElement, value?.DiagramLayoutDefinitionParts);
      //SetDiagramPersistLayoutParts(openXmlElement, value?.DiagramPersistLayoutParts);
      //SetDiagramStyleParts(openXmlElement, value?.DiagramStyleParts);
      //SetExtendedChartParts(openXmlElement, value?.ExtendedChartParts);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetWebExtensionParts(openXmlElement, value?.WebExtensionParts);
      return openXmlElement;
    }
    return default;
  }
}
