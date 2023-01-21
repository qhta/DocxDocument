namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordprocessingCommentsExPart
/// </summary>
public static class WordprocessingCommentsExPartConverter
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.AlternativeFormatImportPart> GetAlternativeFormatImportParts(DXPack.WordprocessingCommentsExPart openXmlElement)
  {
    var collection = new Collection<DMPack.AlternativeFormatImportPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.AlternativeFormatImportPart>())
    {
      var newItem = DMXPack.AlternativeFormatImportPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets the ChartParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.ChartPart> GetChartParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.CommentsEx? GetCommentsEx(DXPack.WordprocessingCommentsExPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2013W.CommentsEx rootElement)
      return DMXW.CommentsExConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetCommentsEx(DXPack.WordprocessingCommentsExPart openXmlElement, DMW.CommentsEx? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.CommentsExConverter.CreateOpenXmlElement<DXO2013W.CommentsEx>(value);
       if (rootElement != null)
         openXmlElement.CommentsEx = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.WordprocessingCommentsExPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.DiagramColorsPart> GetDiagramColorsParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the DiagramDataParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.DiagramDataPart> GetDiagramDataParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.DiagramLayoutDefinitionPart> GetDiagramLayoutDefinitionParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.DiagramPersistLayoutPart> GetDiagramPersistLayoutParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the DiagramStyleParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.DiagramStylePart> GetDiagramStyleParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistencePart> GetEmbeddedControlPersistenceParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the EmbeddedObjectParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.EmbeddedObjectPart> GetEmbeddedObjectParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the EmbeddedPackageParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.EmbeddedPackagePart> GetEmbeddedPackageParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the ExtendedChartParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.ExtendedChartPart> GetExtendedChartParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the ImageParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsExPart
  /// </summary>
  private static Collection<DMPack.Model3DReferenceRelationshipPart> GetModel3DReferenceRelationshipParts(DXPack.WordprocessingCommentsExPart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.WordprocessingCommentsExPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.WordprocessingCommentsExPart? CreateModelElement(DXPack.WordprocessingCommentsExPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WordprocessingCommentsExPart();
      value.AlternativeFormatImportParts = GetAlternativeFormatImportParts(openXmlElement);
      value.ChartParts = GetChartParts(openXmlElement);
      value.CommentsEx = GetCommentsEx(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.DiagramColorsParts = GetDiagramColorsParts(openXmlElement);
      value.DiagramDataParts = GetDiagramDataParts(openXmlElement);
      value.DiagramLayoutDefinitionParts = GetDiagramLayoutDefinitionParts(openXmlElement);
      value.DiagramPersistLayoutParts = GetDiagramPersistLayoutParts(openXmlElement);
      value.DiagramStyleParts = GetDiagramStyleParts(openXmlElement);
      value.EmbeddedControlPersistenceParts = GetEmbeddedControlPersistenceParts(openXmlElement);
      value.EmbeddedObjectParts = GetEmbeddedObjectParts(openXmlElement);
      value.EmbeddedPackageParts = GetEmbeddedPackageParts(openXmlElement);
      value.ExtendedChartParts = GetExtendedChartParts(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordprocessingCommentsExPart? value)
    where OpenXmlElementType: DXPack.WordprocessingCommentsExPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetAlternativeFormatImportParts(openXmlElement, value?.AlternativeFormatImportParts);
      //SetChartParts(openXmlElement, value?.ChartParts);
      SetCommentsEx(openXmlElement, value?.CommentsEx);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetDiagramColorsParts(openXmlElement, value?.DiagramColorsParts);
      //SetDiagramDataParts(openXmlElement, value?.DiagramDataParts);
      //SetDiagramLayoutDefinitionParts(openXmlElement, value?.DiagramLayoutDefinitionParts);
      //SetDiagramPersistLayoutParts(openXmlElement, value?.DiagramPersistLayoutParts);
      //SetDiagramStyleParts(openXmlElement, value?.DiagramStyleParts);
      //SetEmbeddedControlPersistenceParts(openXmlElement, value?.EmbeddedControlPersistenceParts);
      //SetEmbeddedObjectParts(openXmlElement, value?.EmbeddedObjectParts);
      //SetEmbeddedPackageParts(openXmlElement, value?.EmbeddedPackageParts);
      //SetExtendedChartParts(openXmlElement, value?.ExtendedChartParts);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
