namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the GlossaryDocumentPart
/// </summary>
public static class GlossaryDocumentPartConverter
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.AlternativeFormatImportPart>? GetAlternativeFormatImportParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpAlternativeFormatImportParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.AlternativeFormatImportPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.ChartPart>? GetChartParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpChartParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.ChartPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetContentType(DXPack.GlossaryDocumentPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.GlossaryDocumentPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.DiagramColorsPart>? GetDiagramColorsParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpDiagramColorsParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.DiagramColorsPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.DiagramDataPart>? GetDiagramDataParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpDiagramDataParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.DiagramDataPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpDiagramLayoutDefinitionParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.DiagramLayoutDefinitionPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpDiagramPersistLayoutParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.DiagramPersistLayoutPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.DiagramStylePart>? GetDiagramStyleParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpDiagramStyleParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.DiagramStylePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpEmbeddedControlPersistenceParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.EmbeddedControlPersistencePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.EmbeddedObjectPart>? GetEmbeddedObjectParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpEmbeddedObjectParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.EmbeddedObjectPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.EmbeddedPackagePart>? GetEmbeddedPackageParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpEmbeddedPackageParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.EmbeddedPackagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.ExtendedChartPart>? GetExtendedChartParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpExtendedChartParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.ExtendedChartPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.FooterPart>? GetFooterParts(DXPack.GlossaryDocumentPart openXmlElement)
  {
    var collection = new Collection<DMPack.FooterPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.FooterPart>())
    {
      var newItem = DMXPack.FooterPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpFooterParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.FooterPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.GlossaryDocument? GetGlossaryDocument(DXPack.GlossaryDocumentPart openXmlElement)
  {
      return DMXW.GlossaryDocumentConverter.CreateModelElement(openXmlElement?.RootElement as DXW.GlossaryDocument);
  }
  
  private static bool CmpGlossaryDocument(DXPack.GlossaryDocumentPart openXmlElement, DMW.GlossaryDocument? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetGlossaryDocument(DXPack.GlossaryDocumentPart openXmlElement, DMW.GlossaryDocument? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.GlossaryDocumentConverter.CreateOpenXmlElement<DXW.GlossaryDocument>(value);
       if (rootElement != null)
         openXmlElement.GlossaryDocument = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.HeaderPart>? GetHeaderParts(DXPack.GlossaryDocumentPart openXmlElement)
  {
    var collection = new Collection<DMPack.HeaderPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.HeaderPart>())
    {
      var newItem = DMXPack.HeaderPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpHeaderParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.HeaderPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(DXPack.GlossaryDocumentPart openXmlElement)
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
  
  private static bool CmpModel3DReferenceRelationshipParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.Model3DReferenceRelationshipPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.GlossaryDocumentPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.GlossaryDocumentPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  private static Collection<DMPack.WordprocessingPrinterSettingsPart>? GetWordprocessingPrinterSettingsParts(DXPack.GlossaryDocumentPart openXmlElement)
  {
    var collection = new Collection<DMPack.WordprocessingPrinterSettingsPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.WordprocessingPrinterSettingsPart>())
    {
      var newItem = DMXPack.WordprocessingPrinterSettingsPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpWordprocessingPrinterSettingsParts(DXPack.GlossaryDocumentPart openXmlElement, Collection<DMPack.WordprocessingPrinterSettingsPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  public static DocumentModel.Packaging.GlossaryDocumentPart? CreateModelElement(DXPack.GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.GlossaryDocumentPart();
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
      value.FooterParts = GetFooterParts(openXmlElement);
      value.GlossaryDocument = GetGlossaryDocument(openXmlElement);
      value.HeaderParts = GetHeaderParts(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WordprocessingPrinterSettingsParts = GetWordprocessingPrinterSettingsParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.GlossaryDocumentPart? openXmlElement, DMPack.GlossaryDocumentPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlternativeFormatImportParts(openXmlElement, value.AlternativeFormatImportParts, diffs, objName))
        ok = false;
      if (!CmpChartParts(openXmlElement, value.ChartParts, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpDiagramColorsParts(openXmlElement, value.DiagramColorsParts, diffs, objName))
        ok = false;
      if (!CmpDiagramDataParts(openXmlElement, value.DiagramDataParts, diffs, objName))
        ok = false;
      if (!CmpDiagramLayoutDefinitionParts(openXmlElement, value.DiagramLayoutDefinitionParts, diffs, objName))
        ok = false;
      if (!CmpDiagramPersistLayoutParts(openXmlElement, value.DiagramPersistLayoutParts, diffs, objName))
        ok = false;
      if (!CmpDiagramStyleParts(openXmlElement, value.DiagramStyleParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedControlPersistenceParts(openXmlElement, value.EmbeddedControlPersistenceParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedObjectParts(openXmlElement, value.EmbeddedObjectParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedPackageParts(openXmlElement, value.EmbeddedPackageParts, diffs, objName))
        ok = false;
      if (!CmpExtendedChartParts(openXmlElement, value.ExtendedChartParts, diffs, objName))
        ok = false;
      if (!CmpFooterParts(openXmlElement, value.FooterParts, diffs, objName))
        ok = false;
      if (!CmpGlossaryDocument(openXmlElement, value.GlossaryDocument, diffs, objName))
        ok = false;
      if (!CmpHeaderParts(openXmlElement, value.HeaderParts, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpModel3DReferenceRelationshipParts(openXmlElement, value.Model3DReferenceRelationshipParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpWordprocessingPrinterSettingsParts(openXmlElement, value.WordprocessingPrinterSettingsParts, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.GlossaryDocumentPart? value)
    where OpenXmlElementType: DXPack.GlossaryDocumentPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      //SetFooterParts(openXmlElement, value?.FooterParts);
      SetGlossaryDocument(openXmlElement, value?.GlossaryDocument);
      //SetHeaderParts(openXmlElement, value?.HeaderParts);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetWordprocessingPrinterSettingsParts(openXmlElement, value?.WordprocessingPrinterSettingsParts);
      return openXmlElement;
    }
    return default;
  }
}
