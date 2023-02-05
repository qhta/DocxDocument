namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetPart
/// </summary>
public static class WorksheetPartConverter
{
  private static String? GetContentType(DXPack.WorksheetPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.WorksheetPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.ControlPropertiesPart> GetControlPropertiesParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.ControlPropertiesPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ControlPropertiesPart>())
    {
      var newItem = DMXPack.ControlPropertiesPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpControlPropertiesParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.ControlPropertiesPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.CustomPropertyPart> GetCustomPropertyParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.CustomPropertyPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.CustomPropertyPart>())
    {
      var newItem = DMXPack.CustomPropertyPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpCustomPropertyParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.CustomPropertyPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart> GetEmbeddedControlPersistenceBinaryDataParts(DXPack.WorksheetPart openXmlElement)
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
  
  private static bool CmpEmbeddedControlPersistenceBinaryDataParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistencePart> GetEmbeddedControlPersistenceParts(DXPack.WorksheetPart openXmlElement)
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
  
  private static bool CmpEmbeddedControlPersistenceParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.EmbeddedControlPersistencePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.EmbeddedObjectPart> GetEmbeddedObjectParts(DXPack.WorksheetPart openXmlElement)
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
  
  private static bool CmpEmbeddedObjectParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.EmbeddedObjectPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.EmbeddedPackagePart> GetEmbeddedPackageParts(DXPack.WorksheetPart openXmlElement)
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
  
  private static bool CmpEmbeddedPackageParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.EmbeddedPackagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.WorksheetPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.Model3DReferenceRelationshipPart> GetModel3DReferenceRelationshipParts(DXPack.WorksheetPart openXmlElement)
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
  
  private static bool CmpModel3DReferenceRelationshipParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.Model3DReferenceRelationshipPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.NamedSheetViewsPart> GetNamedSheetViewsParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.NamedSheetViewsPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.NamedSheetViewsPart>())
    {
      var newItem = DMXPack.NamedSheetViewsPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNamedSheetViewsParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.NamedSheetViewsPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.PivotTablePart> GetPivotTableParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.PivotTablePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.PivotTablePart>())
    {
      var newItem = DMXPack.PivotTablePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpPivotTableParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.PivotTablePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.QueryTablePart> GetQueryTableParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.QueryTablePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.QueryTablePart>())
    {
      var newItem = DMXPack.QueryTablePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpQueryTableParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.QueryTablePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.WorksheetPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WorksheetPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the SlicersParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.SlicersPart> GetSlicersParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.SlicersPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.SlicersPart>())
    {
      var newItem = DMXPack.SlicersPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSlicersParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.SlicersPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.SpreadsheetPrinterSettingsPart> GetSpreadsheetPrinterSettingsParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.SpreadsheetPrinterSettingsPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.SpreadsheetPrinterSettingsPart>())
    {
      var newItem = DMXPack.SpreadsheetPrinterSettingsPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSpreadsheetPrinterSettingsParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.SpreadsheetPrinterSettingsPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.TableDefinitionPart> GetTableDefinitionParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.TableDefinitionPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.TableDefinitionPart>())
    {
      var newItem = DMXPack.TableDefinitionPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpTableDefinitionParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.TableDefinitionPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.TimeLinePart> GetTimeLineParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.TimeLinePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.TimeLinePart>())
    {
      var newItem = DMXPack.TimeLinePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpTimeLineParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.TimeLinePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.VmlDrawingPart> GetVmlDrawingParts(DXPack.WorksheetPart openXmlElement)
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
  
  private static bool CmpVmlDrawingParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.VmlDrawingPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  private static Collection<DMPack.WorksheetThreadedCommentsPart> GetWorksheetThreadedCommentsParts(DXPack.WorksheetPart openXmlElement)
  {
    var collection = new Collection<DMPack.WorksheetThreadedCommentsPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.WorksheetThreadedCommentsPart>())
    {
      var newItem = DMXPack.WorksheetThreadedCommentsPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpWorksheetThreadedCommentsParts(DXPack.WorksheetPart openXmlElement, Collection<DMPack.WorksheetThreadedCommentsPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  public static DMPack.WorksheetPart? CreateModelElement(DXPack.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WorksheetPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ControlPropertiesParts = GetControlPropertiesParts(openXmlElement);
      value.CustomPropertyParts = GetCustomPropertyParts(openXmlElement);
      value.EmbeddedControlPersistenceBinaryDataParts = GetEmbeddedControlPersistenceBinaryDataParts(openXmlElement);
      value.EmbeddedControlPersistenceParts = GetEmbeddedControlPersistenceParts(openXmlElement);
      value.EmbeddedObjectParts = GetEmbeddedObjectParts(openXmlElement);
      value.EmbeddedPackageParts = GetEmbeddedPackageParts(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.NamedSheetViewsParts = GetNamedSheetViewsParts(openXmlElement);
      value.PivotTableParts = GetPivotTableParts(openXmlElement);
      value.QueryTableParts = GetQueryTableParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.SlicersParts = GetSlicersParts(openXmlElement);
      value.SpreadsheetPrinterSettingsParts = GetSpreadsheetPrinterSettingsParts(openXmlElement);
      value.TableDefinitionParts = GetTableDefinitionParts(openXmlElement);
      value.TimeLineParts = GetTimeLineParts(openXmlElement);
      value.VmlDrawingParts = GetVmlDrawingParts(openXmlElement);
      value.WorksheetThreadedCommentsParts = GetWorksheetThreadedCommentsParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.WorksheetPart? openXmlElement, DMPack.WorksheetPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpControlPropertiesParts(openXmlElement, value.ControlPropertiesParts, diffs, objName))
        ok = false;
      if (!CmpCustomPropertyParts(openXmlElement, value.CustomPropertyParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedControlPersistenceBinaryDataParts(openXmlElement, value.EmbeddedControlPersistenceBinaryDataParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedControlPersistenceParts(openXmlElement, value.EmbeddedControlPersistenceParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedObjectParts(openXmlElement, value.EmbeddedObjectParts, diffs, objName))
        ok = false;
      if (!CmpEmbeddedPackageParts(openXmlElement, value.EmbeddedPackageParts, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpModel3DReferenceRelationshipParts(openXmlElement, value.Model3DReferenceRelationshipParts, diffs, objName))
        ok = false;
      if (!CmpNamedSheetViewsParts(openXmlElement, value.NamedSheetViewsParts, diffs, objName))
        ok = false;
      if (!CmpPivotTableParts(openXmlElement, value.PivotTableParts, diffs, objName))
        ok = false;
      if (!CmpQueryTableParts(openXmlElement, value.QueryTableParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpSlicersParts(openXmlElement, value.SlicersParts, diffs, objName))
        ok = false;
      if (!CmpSpreadsheetPrinterSettingsParts(openXmlElement, value.SpreadsheetPrinterSettingsParts, diffs, objName))
        ok = false;
      if (!CmpTableDefinitionParts(openXmlElement, value.TableDefinitionParts, diffs, objName))
        ok = false;
      if (!CmpTimeLineParts(openXmlElement, value.TimeLineParts, diffs, objName))
        ok = false;
      if (!CmpVmlDrawingParts(openXmlElement, value.VmlDrawingParts, diffs, objName))
        ok = false;
      if (!CmpWorksheetThreadedCommentsParts(openXmlElement, value.WorksheetThreadedCommentsParts, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WorksheetPart? value)
    where OpenXmlElementType: DXPack.WorksheetPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetControlPropertiesParts(openXmlElement, value?.ControlPropertiesParts);
      //SetCustomPropertyParts(openXmlElement, value?.CustomPropertyParts);
      //SetEmbeddedControlPersistenceBinaryDataParts(openXmlElement, value?.EmbeddedControlPersistenceBinaryDataParts);
      //SetEmbeddedControlPersistenceParts(openXmlElement, value?.EmbeddedControlPersistenceParts);
      //SetEmbeddedObjectParts(openXmlElement, value?.EmbeddedObjectParts);
      //SetEmbeddedPackageParts(openXmlElement, value?.EmbeddedPackageParts);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetNamedSheetViewsParts(openXmlElement, value?.NamedSheetViewsParts);
      //SetPivotTableParts(openXmlElement, value?.PivotTableParts);
      //SetQueryTableParts(openXmlElement, value?.QueryTableParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetSlicersParts(openXmlElement, value?.SlicersParts);
      //SetSpreadsheetPrinterSettingsParts(openXmlElement, value?.SpreadsheetPrinterSettingsParts);
      //SetTableDefinitionParts(openXmlElement, value?.TableDefinitionParts);
      //SetTimeLineParts(openXmlElement, value?.TimeLineParts);
      //SetVmlDrawingParts(openXmlElement, value?.VmlDrawingParts);
      //SetWorksheetThreadedCommentsParts(openXmlElement, value?.WorksheetThreadedCommentsParts);
      return openXmlElement;
    }
    return default;
  }
}
