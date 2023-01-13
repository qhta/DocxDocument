namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetPart
/// </summary>
public static class WorksheetPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ControlPropertiesPart>? GetControlPropertiesParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ControlPropertiesPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ControlPropertiesPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.ControlPropertiesPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.CustomPropertyPart>? GetCustomPropertyParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.CustomPropertyPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomPropertyPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.CustomPropertyPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? GetEmbeddedControlPersistenceBinaryDataParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.EmbeddedControlPersistencePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedObjectPart>? GetEmbeddedObjectParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedObjectPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.EmbeddedObjectPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedPackagePart>? GetEmbeddedPackageParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedPackagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.EmbeddedPackagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.ImagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.Model3DReferenceRelationshipPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.NamedSheetViewsPart>? GetNamedSheetViewsParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.NamedSheetViewsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.NamedSheetViewsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.PivotTablePart>? GetPivotTableParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.PivotTablePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PivotTablePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.PivotTablePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.QueryTablePart>? GetQueryTableParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.QueryTablePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.QueryTablePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the SlicersParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SlicersPart>? GetSlicersParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SlicersPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlicersPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.SlicersPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SpreadsheetPrinterSettingsPart>? GetSpreadsheetPrinterSettingsParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SpreadsheetPrinterSettingsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.SpreadsheetPrinterSettingsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.TableDefinitionPart>? GetTableDefinitionParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.TableDefinitionPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TableDefinitionPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.TableDefinitionPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.TimeLinePart>? GetTimeLineParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.TimeLinePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TimeLinePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.TimeLinePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.VmlDrawingPart>? GetVmlDrawingParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.VmlDrawingPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.VmlDrawingPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.VmlDrawingPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WorksheetThreadedCommentsPart>? GetWorksheetThreadedCommentsParts(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WorksheetThreadedCommentsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.WorksheetThreadedCommentsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static DocumentModel.Packaging.WorksheetPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WorksheetPart();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WorksheetPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WorksheetPart, new()
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
