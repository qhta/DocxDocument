namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the HeaderPart
/// </summary>
public static class HeaderPartConverter
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.AlternativeFormatImportPart>? GetAlternativeFormatImportParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpAlternativeFormatImportParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.AlternativeFormatImportPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the ChartParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.ChartPart>? GetChartParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpChartParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.ChartPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  private static String? GetContentType(DXPack.HeaderPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.HeaderPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.DiagramColorsPart>? GetDiagramColorsParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpDiagramColorsParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.DiagramColorsPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.DiagramDataPart>? GetDiagramDataParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpDiagramDataParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.DiagramDataPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpDiagramLayoutDefinitionParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.DiagramLayoutDefinitionPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpDiagramPersistLayoutParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.DiagramPersistLayoutPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.DiagramStylePart>? GetDiagramStyleParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpDiagramStyleParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.DiagramStylePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpEmbeddedControlPersistenceParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.EmbeddedControlPersistencePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.EmbeddedObjectPart>? GetEmbeddedObjectParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpEmbeddedObjectParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.EmbeddedObjectPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.EmbeddedPackagePart>? GetEmbeddedPackageParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpEmbeddedPackageParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.EmbeddedPackagePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.ExtendedChartPart>? GetExtendedChartParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpExtendedChartParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.ExtendedChartPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.Header? GetHeader(DXPack.HeaderPart openXmlElement)
  {
      return DMXW.HeaderConverter.CreateModelElement(openXmlElement?.RootElement as DXW.Header);
  }
  
  private static bool CmpHeader(DXPack.HeaderPart openXmlElement, DMW.Header? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetHeader(DXPack.HeaderPart openXmlElement, DMW.Header? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.HeaderConverter.CreateOpenXmlElement(value);
       if (rootElement != null)
         openXmlElement.Header = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the HeaderPart
  /// </summary>
  private static Collection<DMPack.Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(DXPack.HeaderPart openXmlElement)
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
  
  private static bool CmpModel3DReferenceRelationshipParts(DXPack.HeaderPart openXmlElement, Collection<DMPack.Model3DReferenceRelationshipPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.HeaderPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.HeaderPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.HeaderPart? CreateModelElement(DXPack.HeaderPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.HeaderPart();
      value.AlternativeFormatImportParts = GetAlternativeFormatImportParts(openXmlElement);
      value.ChartParts = GetChartParts(openXmlElement);
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
      value.Header = GetHeader(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.HeaderPart? openXmlElement, DMPack.HeaderPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlternativeFormatImportParts(openXmlElement, value.AlternativeFormatImportParts, diffs, objName, propName))
        ok = false;
      if (!CmpChartParts(openXmlElement, value.ChartParts, diffs, objName, propName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpDiagramColorsParts(openXmlElement, value.DiagramColorsParts, diffs, objName, propName))
        ok = false;
      if (!CmpDiagramDataParts(openXmlElement, value.DiagramDataParts, diffs, objName, propName))
        ok = false;
      if (!CmpDiagramLayoutDefinitionParts(openXmlElement, value.DiagramLayoutDefinitionParts, diffs, objName, propName))
        ok = false;
      if (!CmpDiagramPersistLayoutParts(openXmlElement, value.DiagramPersistLayoutParts, diffs, objName, propName))
        ok = false;
      if (!CmpDiagramStyleParts(openXmlElement, value.DiagramStyleParts, diffs, objName, propName))
        ok = false;
      if (!CmpEmbeddedControlPersistenceParts(openXmlElement, value.EmbeddedControlPersistenceParts, diffs, objName, propName))
        ok = false;
      if (!CmpEmbeddedObjectParts(openXmlElement, value.EmbeddedObjectParts, diffs, objName, propName))
        ok = false;
      if (!CmpEmbeddedPackageParts(openXmlElement, value.EmbeddedPackageParts, diffs, objName, propName))
        ok = false;
      if (!CmpExtendedChartParts(openXmlElement, value.ExtendedChartParts, diffs, objName, propName))
        ok = false;
      if (!CmpHeader(openXmlElement, value.Header, diffs, objName, propName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName, propName))
        ok = false;
      if (!CmpModel3DReferenceRelationshipParts(openXmlElement, value.Model3DReferenceRelationshipParts, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.HeaderPart value)
    where OpenXmlElementType: DXPack.HeaderPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.HeaderPart openXmlElement, DMPack.HeaderPart value)
  {
    //SetAlternativeFormatImportParts(openXmlElement, value?.AlternativeFormatImportParts);
    //SetChartParts(openXmlElement, value?.ChartParts);
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
    SetHeader(openXmlElement, value?.Header);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
