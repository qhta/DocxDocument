using DocumentFormat.OpenXml.Packaging;
using ControlPropertiesPart = DocumentModel.Packaging.ControlPropertiesPart;
using CustomPropertyPart = DocumentModel.Packaging.CustomPropertyPart;
using EmbeddedControlPersistenceBinaryDataPart = DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart;
using EmbeddedControlPersistencePart = DocumentModel.Packaging.EmbeddedControlPersistencePart;
using EmbeddedObjectPart = DocumentModel.Packaging.EmbeddedObjectPart;
using EmbeddedPackagePart = DocumentModel.Packaging.EmbeddedPackagePart;
using ImagePart = DocumentModel.Packaging.ImagePart;
using Model3DReferenceRelationshipPart = DocumentModel.Packaging.Model3DReferenceRelationshipPart;
using NamedSheetViewsPart = DocumentModel.Packaging.NamedSheetViewsPart;
using PivotTablePart = DocumentModel.Packaging.PivotTablePart;
using QueryTablePart = DocumentModel.Packaging.QueryTablePart;
using SlicersPart = DocumentModel.Packaging.SlicersPart;
using SpreadsheetPrinterSettingsPart = DocumentModel.Packaging.SpreadsheetPrinterSettingsPart;
using TableDefinitionPart = DocumentModel.Packaging.TableDefinitionPart;
using TimeLinePart = DocumentModel.Packaging.TimeLinePart;
using VmlDrawingPart = DocumentModel.Packaging.VmlDrawingPart;
using WorksheetThreadedCommentsPart = DocumentModel.Packaging.WorksheetThreadedCommentsPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the WorksheetPart
/// </summary>
public static class WorksheetPartConverter
{
  public static String? GetContentType(WorksheetPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  public static Collection<ControlPropertiesPart>? GetControlPropertiesParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ControlPropertiesPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ControlPropertiesPart>())
      {
        var newItem = ControlPropertiesPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  public static Collection<CustomPropertyPart>? GetCustomPropertyParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CustomPropertyPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomPropertyPart>())
      {
        var newItem = CustomPropertyPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
  /// </summary>
  public static Collection<EmbeddedControlPersistenceBinaryDataPart>? GetEmbeddedControlPersistenceBinaryDataParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<EmbeddedControlPersistenceBinaryDataPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>())
      {
        var newItem = EmbeddedControlPersistenceBinaryDataPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the WorksheetPart
  /// </summary>
  public static Collection<EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<EmbeddedControlPersistencePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>())
      {
        var newItem = EmbeddedControlPersistencePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the WorksheetPart
  /// </summary>
  public static Collection<EmbeddedObjectPart>? GetEmbeddedObjectParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<EmbeddedObjectPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>())
      {
        var newItem = EmbeddedObjectPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the WorksheetPart
  /// </summary>
  public static Collection<EmbeddedPackagePart>? GetEmbeddedPackageParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<EmbeddedPackagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>())
      {
        var newItem = EmbeddedPackagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the ImageParts of the WorksheetPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ImagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
      {
        var newItem = ImagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the WorksheetPart
  /// </summary>
  public static Collection<Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Model3DReferenceRelationshipPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>())
      {
        var newItem = Model3DReferenceRelationshipPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  public static Collection<NamedSheetViewsPart>? GetNamedSheetViewsParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NamedSheetViewsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart>())
      {
        var newItem = NamedSheetViewsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  public static Collection<PivotTablePart>? GetPivotTableParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<PivotTablePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PivotTablePart>())
      {
        var newItem = PivotTablePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  public static Collection<QueryTablePart>? GetQueryTableParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<QueryTablePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>())
      {
        var newItem = QueryTablePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static String? GetRelationshipType(WorksheetPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets the SlicersParts of the WorksheetPart
  /// </summary>
  public static Collection<SlicersPart>? GetSlicersParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SlicersPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlicersPart>())
      {
        var newItem = SlicersPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  public static Collection<SpreadsheetPrinterSettingsPart>? GetSpreadsheetPrinterSettingsParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SpreadsheetPrinterSettingsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart>())
      {
        var newItem = SpreadsheetPrinterSettingsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  public static Collection<TableDefinitionPart>? GetTableDefinitionParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<TableDefinitionPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TableDefinitionPart>())
      {
        var newItem = TableDefinitionPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  public static Collection<TimeLinePart>? GetTimeLineParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<TimeLinePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TimeLinePart>())
      {
        var newItem = TimeLinePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the VmlDrawingParts of the WorksheetPart
  /// </summary>
  public static Collection<VmlDrawingPart>? GetVmlDrawingParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<VmlDrawingPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.VmlDrawingPart>())
      {
        var newItem = VmlDrawingPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  public static Collection<WorksheetThreadedCommentsPart>? GetWorksheetThreadedCommentsParts(WorksheetPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<WorksheetThreadedCommentsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart>())
      {
        var newItem = WorksheetThreadedCommentsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static DocumentModel.Packaging.WorksheetPart? CreateModelElement(WorksheetPart? openXmlElement)
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
    where OpenXmlElementType : WorksheetPart, new()
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