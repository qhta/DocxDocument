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
  
  private static bool CmpContentType(DXPack.DiagramPersistLayoutPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsO.Drawing? GetDrawing(DXPack.DiagramPersistLayoutPart openXmlElement)
  {
      return DMXDrawsO.DrawingConverter.CreateModelElement(openXmlElement?.RootElement as DXODraw.Drawing);
  }
  
  private static bool CmpDrawing(DXPack.DiagramPersistLayoutPart openXmlElement, DMDrawsO.Drawing? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  private static bool CmpImageParts(DXPack.DiagramPersistLayoutPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.DiagramPersistLayoutPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DiagramPersistLayoutPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
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
  
  public static bool CompareModelElement(DXPack.DiagramPersistLayoutPart? openXmlElement, DMPack.DiagramPersistLayoutPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpDrawing(openXmlElement, value.Drawing, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
