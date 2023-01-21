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
  
  private static String? GetRelationshipType(DXPack.WorksheetPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
