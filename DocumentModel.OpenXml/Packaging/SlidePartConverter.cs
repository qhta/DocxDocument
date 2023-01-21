namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlidePart
/// </summary>
public static class SlidePartConverter
{
  /// <summary>
  /// Gets the ChartParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.ChartPart> GetChartParts(DXPack.SlidePart openXmlElement)
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
  
  /// <summary>
  /// Gets the commentParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.PowerPointCommentPart> GetcommentParts(DXPack.SlidePart openXmlElement)
  {
    var collection = new Collection<DMPack.PowerPointCommentPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.PowerPointCommentPart>())
    {
      var newItem = DMXPack.PowerPointCommentPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static String? GetContentType(DXPack.SlidePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.CustomXmlPart> GetCustomXmlParts(DXPack.SlidePart openXmlElement)
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
  /// Gets the DiagramColorsParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.DiagramColorsPart> GetDiagramColorsParts(DXPack.SlidePart openXmlElement)
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
  /// Gets the DiagramDataParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.DiagramDataPart> GetDiagramDataParts(DXPack.SlidePart openXmlElement)
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
  /// Gets the DiagramLayoutDefinitionParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.DiagramLayoutDefinitionPart> GetDiagramLayoutDefinitionParts(DXPack.SlidePart openXmlElement)
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
  /// Gets the DiagramPersistLayoutParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.DiagramPersistLayoutPart> GetDiagramPersistLayoutParts(DXPack.SlidePart openXmlElement)
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
  /// Gets the DiagramStyleParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.DiagramStylePart> GetDiagramStyleParts(DXPack.SlidePart openXmlElement)
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
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart> GetEmbeddedControlPersistenceBinaryDataParts(DXPack.SlidePart openXmlElement)
  {
    var collection = new Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.EmbeddedControlPersistenceBinaryDataPart>())
    {
      var newItem = DMXPack.EmbeddedControlPersistenceBinaryDataPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistencePart> GetEmbeddedControlPersistenceParts(DXPack.SlidePart openXmlElement)
  {
    var collection = new Collection<DMPack.EmbeddedControlPersistencePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.EmbeddedControlPersistencePart>())
    {
      var newItem = DMXPack.EmbeddedControlPersistencePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.EmbeddedObjectPart> GetEmbeddedObjectParts(DXPack.SlidePart openXmlElement)
  {
    var collection = new Collection<DMPack.EmbeddedObjectPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.EmbeddedObjectPart>())
    {
      var newItem = DMXPack.EmbeddedObjectPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.EmbeddedPackagePart> GetEmbeddedPackageParts(DXPack.SlidePart openXmlElement)
  {
    var collection = new Collection<DMPack.EmbeddedPackagePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.EmbeddedPackagePart>())
    {
      var newItem = DMXPack.EmbeddedPackagePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.ExtendedChartPart> GetExtendedChartParts(DXPack.SlidePart openXmlElement)
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
  /// Gets the ImageParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.SlidePart openXmlElement)
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
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.Model3DReferenceRelationshipPart> GetModel3DReferenceRelationshipParts(DXPack.SlidePart openXmlElement)
  {
    var collection = new Collection<DMPack.Model3DReferenceRelationshipPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.Model3DReferenceRelationshipPart>())
    {
      var newItem = DMXPack.Model3DReferenceRelationshipPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static String? GetRelationshipType(DXPack.SlidePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the SlideParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.SlidePart> GetSlideParts(DXPack.SlidePart openXmlElement)
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
  /// Gets the UserDefinedTagsParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.UserDefinedTagsPart> GetUserDefinedTagsParts(DXPack.SlidePart openXmlElement)
  {
    var collection = new Collection<DMPack.UserDefinedTagsPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.UserDefinedTagsPart>())
    {
      var newItem = DMXPack.UserDefinedTagsPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.VmlDrawingPart> GetVmlDrawingParts(DXPack.SlidePart openXmlElement)
  {
    var collection = new Collection<DMPack.VmlDrawingPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.VmlDrawingPart>())
    {
      var newItem = DMXPack.VmlDrawingPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the SlidePart
  /// </summary>
  private static Collection<DMPack.WebExtensionPart> GetWebExtensionParts(DXPack.SlidePart openXmlElement)
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
  
  public static DMPack.SlidePart? CreateModelElement(DXPack.SlidePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.SlidePart();
      value.ChartParts = GetChartParts(openXmlElement);
      value.commentParts = GetcommentParts(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.CustomXmlParts = GetCustomXmlParts(openXmlElement);
      value.DiagramColorsParts = GetDiagramColorsParts(openXmlElement);
      value.DiagramDataParts = GetDiagramDataParts(openXmlElement);
      value.DiagramLayoutDefinitionParts = GetDiagramLayoutDefinitionParts(openXmlElement);
      value.DiagramPersistLayoutParts = GetDiagramPersistLayoutParts(openXmlElement);
      value.DiagramStyleParts = GetDiagramStyleParts(openXmlElement);
      value.EmbeddedControlPersistenceBinaryDataParts = GetEmbeddedControlPersistenceBinaryDataParts(openXmlElement);
      value.EmbeddedControlPersistenceParts = GetEmbeddedControlPersistenceParts(openXmlElement);
      value.EmbeddedObjectParts = GetEmbeddedObjectParts(openXmlElement);
      value.EmbeddedPackageParts = GetEmbeddedPackageParts(openXmlElement);
      value.ExtendedChartParts = GetExtendedChartParts(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.SlideParts = GetSlideParts(openXmlElement);
      value.UserDefinedTagsParts = GetUserDefinedTagsParts(openXmlElement);
      value.VmlDrawingParts = GetVmlDrawingParts(openXmlElement);
      value.WebExtensionParts = GetWebExtensionParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.SlidePart? value)
    where OpenXmlElementType: DXPack.SlidePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetChartParts(openXmlElement, value?.ChartParts);
      //SetcommentParts(openXmlElement, value?.commentParts);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetCustomXmlParts(openXmlElement, value?.CustomXmlParts);
      //SetDiagramColorsParts(openXmlElement, value?.DiagramColorsParts);
      //SetDiagramDataParts(openXmlElement, value?.DiagramDataParts);
      //SetDiagramLayoutDefinitionParts(openXmlElement, value?.DiagramLayoutDefinitionParts);
      //SetDiagramPersistLayoutParts(openXmlElement, value?.DiagramPersistLayoutParts);
      //SetDiagramStyleParts(openXmlElement, value?.DiagramStyleParts);
      //SetEmbeddedControlPersistenceBinaryDataParts(openXmlElement, value?.EmbeddedControlPersistenceBinaryDataParts);
      //SetEmbeddedControlPersistenceParts(openXmlElement, value?.EmbeddedControlPersistenceParts);
      //SetEmbeddedObjectParts(openXmlElement, value?.EmbeddedObjectParts);
      //SetEmbeddedPackageParts(openXmlElement, value?.EmbeddedPackageParts);
      //SetExtendedChartParts(openXmlElement, value?.ExtendedChartParts);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetSlideParts(openXmlElement, value?.SlideParts);
      //SetUserDefinedTagsParts(openXmlElement, value?.UserDefinedTagsParts);
      //SetVmlDrawingParts(openXmlElement, value?.VmlDrawingParts);
      //SetWebExtensionParts(openXmlElement, value?.WebExtensionParts);
      return openXmlElement;
    }
    return default;
  }
}
