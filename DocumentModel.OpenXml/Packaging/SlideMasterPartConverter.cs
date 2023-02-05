namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlideMasterPart
/// </summary>
public static class SlideMasterPartConverter
{
  /// <summary>
  /// Gets the ChartParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.ChartPart> GetChartParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpChartParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.ChartPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetContentType(DXPack.SlideMasterPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.SlideMasterPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.CustomXmlPart> GetCustomXmlParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpCustomXmlParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.CustomXmlPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.DiagramColorsPart> GetDiagramColorsParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpDiagramColorsParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.DiagramColorsPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.DiagramDataPart> GetDiagramDataParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpDiagramDataParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.DiagramDataPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.DiagramLayoutDefinitionPart> GetDiagramLayoutDefinitionParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpDiagramLayoutDefinitionParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.DiagramLayoutDefinitionPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.DiagramPersistLayoutPart> GetDiagramPersistLayoutParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpDiagramPersistLayoutParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.DiagramPersistLayoutPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.DiagramStylePart> GetDiagramStyleParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpDiagramStyleParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.DiagramStylePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart> GetEmbeddedControlPersistenceBinaryDataParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpEmbeddedControlPersistenceBinaryDataParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistencePart> GetEmbeddedControlPersistenceParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpEmbeddedControlPersistenceParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.EmbeddedControlPersistencePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.EmbeddedObjectPart> GetEmbeddedObjectParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpEmbeddedObjectParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.EmbeddedObjectPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.EmbeddedPackagePart> GetEmbeddedPackageParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpEmbeddedPackageParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.EmbeddedPackagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.ExtendedChartPart> GetExtendedChartParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpExtendedChartParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.ExtendedChartPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the ImageParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.Model3DReferenceRelationshipPart> GetModel3DReferenceRelationshipParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpModel3DReferenceRelationshipParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.Model3DReferenceRelationshipPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.SlideMasterPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.SlideMasterPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the SlideLayoutParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.SlideLayoutPart> GetSlideLayoutParts(DXPack.SlideMasterPart openXmlElement)
  {
    var collection = new Collection<DMPack.SlideLayoutPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.SlideLayoutPart>())
    {
      var newItem = DMXPack.SlideLayoutPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSlideLayoutParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.SlideLayoutPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the SlideParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.SlidePart> GetSlideParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpSlideParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.SlidePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.UserDefinedTagsPart> GetUserDefinedTagsParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpUserDefinedTagsParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.UserDefinedTagsPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlideMasterPart
  /// </summary>
  private static Collection<DMPack.VmlDrawingPart> GetVmlDrawingParts(DXPack.SlideMasterPart openXmlElement)
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
  
  private static bool CmpVmlDrawingParts(DXPack.SlideMasterPart openXmlElement, Collection<DMPack.VmlDrawingPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  public static DMPack.SlideMasterPart? CreateModelElement(DXPack.SlideMasterPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.SlideMasterPart();
      value.ChartParts = GetChartParts(openXmlElement);
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
      value.SlideLayoutParts = GetSlideLayoutParts(openXmlElement);
      value.SlideParts = GetSlideParts(openXmlElement);
      value.UserDefinedTagsParts = GetUserDefinedTagsParts(openXmlElement);
      value.VmlDrawingParts = GetVmlDrawingParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.SlideMasterPart? openXmlElement, DMPack.SlideMasterPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartParts(openXmlElement, value.ChartParts, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpCustomXmlParts(openXmlElement, value.CustomXmlParts, diffs, objName))
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
      if (!CmpEmbeddedControlPersistenceBinaryDataParts(openXmlElement, value.EmbeddedControlPersistenceBinaryDataParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedControlPersistenceParts(openXmlElement, value.EmbeddedControlPersistenceParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedObjectParts(openXmlElement, value.EmbeddedObjectParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedPackageParts(openXmlElement, value.EmbeddedPackageParts, diffs, objName))
        ok = false;
      if (!CmpExtendedChartParts(openXmlElement, value.ExtendedChartParts, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpModel3DReferenceRelationshipParts(openXmlElement, value.Model3DReferenceRelationshipParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpSlideLayoutParts(openXmlElement, value.SlideLayoutParts, diffs, objName))
        ok = false;
      if (!CmpSlideParts(openXmlElement, value.SlideParts, diffs, objName))
        ok = false;
      if (!CmpUserDefinedTagsParts(openXmlElement, value.UserDefinedTagsParts, diffs, objName))
        ok = false;
      if (!CmpVmlDrawingParts(openXmlElement, value.VmlDrawingParts, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.SlideMasterPart? value)
    where OpenXmlElementType: DXPack.SlideMasterPart, new()
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
      //SetEmbeddedControlPersistenceBinaryDataParts(openXmlElement, value?.EmbeddedControlPersistenceBinaryDataParts);
      //SetEmbeddedControlPersistenceParts(openXmlElement, value?.EmbeddedControlPersistenceParts);
      //SetEmbeddedObjectParts(openXmlElement, value?.EmbeddedObjectParts);
      //SetEmbeddedPackageParts(openXmlElement, value?.EmbeddedPackageParts);
      //SetExtendedChartParts(openXmlElement, value?.ExtendedChartParts);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetSlideLayoutParts(openXmlElement, value?.SlideLayoutParts);
      //SetSlideParts(openXmlElement, value?.SlideParts);
      //SetUserDefinedTagsParts(openXmlElement, value?.UserDefinedTagsParts);
      //SetVmlDrawingParts(openXmlElement, value?.VmlDrawingParts);
      return openXmlElement;
    }
    return default;
  }
}
