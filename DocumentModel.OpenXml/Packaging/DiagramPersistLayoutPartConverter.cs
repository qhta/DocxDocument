namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramPersistLayoutPart
/// </summary>
public static class DiagramPersistLayoutPartConverter
{
  private static String? GetContentType(DXPack.DiagramPersistLayoutPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsO.Drawing? GetDrawing(DXPack.DiagramPersistLayoutPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXODraw.Drawing rootElement)
      return DMXDrawsO.DrawingConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetDrawing(DXPack.DiagramPersistLayoutPart openXmlElement, DMDrawsO.Drawing? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsO.DrawingConverter.CreateOpenXmlElement<DXODraw.Drawing>(value);
       if (rootElement != null)
         openXmlElement.Drawing = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.DiagramPersistLayoutPart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.DiagramPersistLayoutPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.DiagramPersistLayoutPart? CreateModelElement(DXPack.DiagramPersistLayoutPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DiagramPersistLayoutPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Drawing = GetDrawing(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramPersistLayoutPart? value)
    where OpenXmlElementType: DXPack.DiagramPersistLayoutPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetDrawing(openXmlElement, value?.Drawing);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
