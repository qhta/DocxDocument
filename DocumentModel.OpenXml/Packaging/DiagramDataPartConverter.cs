namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public static class DiagramDataPartConverter
{
  private static String? GetContentType(DXPack.DiagramDataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsDgms.DataModelRoot? GetDataModelRoot(DXPack.DiagramDataPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXDrawDgms.DataModelRoot rootElement)
      return DMXDrawsDgms.DataModelRootConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetDataModelRoot(DXPack.DiagramDataPart openXmlElement, DMDrawsDgms.DataModelRoot? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsDgms.DataModelRootConverter.CreateOpenXmlElement<DXDrawDgms.DataModelRoot>(value);
       if (rootElement != null)
         openXmlElement.DataModelRoot = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.DiagramDataPart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.DiagramDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  private static Collection<DMPack.SlidePart> GetSlideParts(DXPack.DiagramDataPart openXmlElement)
  {
    var collection = new Collection<DMPack.SlidePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.SlidePart>())
    {
      var newItem = DMXPack.SlidePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  private static Collection<DMPack.WorksheetPart> GetWorksheetParts(DXPack.DiagramDataPart openXmlElement)
  {
    var collection = new Collection<DMPack.WorksheetPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.WorksheetPart>())
    {
      var newItem = DMXPack.WorksheetPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  public static DMPack.DiagramDataPart? CreateModelElement(DXPack.DiagramDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DiagramDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.DataModelRoot = GetDataModelRoot(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.SlideParts = GetSlideParts(openXmlElement);
      value.WorksheetParts = GetWorksheetParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramDataPart? value)
    where OpenXmlElementType: DXPack.DiagramDataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetDataModelRoot(openXmlElement, value?.DataModelRoot);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetSlideParts(openXmlElement, value?.SlideParts);
      //SetWorksheetParts(openXmlElement, value?.WorksheetParts);
      return openXmlElement;
    }
    return default;
  }
}
