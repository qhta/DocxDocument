namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordprocessingCommentsIdsPart
/// </summary>
public static class WordprocessingCommentsIdsPartConverter
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? GetAlternativeFormatImportParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.AlternativeFormatImportPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.AlternativeFormatImportPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the ChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartPart>? GetChartParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.ChartPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.CommentsIds? GetCommentsIds(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds rootElement)
      return DocumentModel.OpenXml.Wordprocessing.CommentsIdsConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetCommentsIds(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement, DocumentModel.Wordprocessing.CommentsIds? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Wordprocessing.CommentsIdsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds>(value);
         if (rootElement != null)
           openXmlElement.CommentsIds = rootElement;
      }
  }
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramColorsPart>? GetDiagramColorsParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramColorsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.DiagramColorsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramDataPart>? GetDiagramDataParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramDataPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramDataPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.DiagramDataPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.DiagramLayoutDefinitionPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.DiagramPersistLayoutPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramStylePart>? GetDiagramStyleParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramStylePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramStylePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.DiagramStylePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
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
  /// Gets the EmbeddedObjectParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedObjectPart>? GetEmbeddedObjectParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
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
  /// Gets the EmbeddedPackageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedPackagePart>? GetEmbeddedPackageParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
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
  /// Gets the ExtendedChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ExtendedChartPart>? GetExtendedChartParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ExtendedChartPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.ExtendedChartPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
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
  /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.WordprocessingCommentsIdsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WordprocessingCommentsIdsPart();
      value.AlternativeFormatImportParts = GetAlternativeFormatImportParts(openXmlElement);
      value.ChartParts = GetChartParts(openXmlElement);
      value.CommentsIds = GetCommentsIds(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WordprocessingCommentsIdsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetAlternativeFormatImportParts(openXmlElement, value?.AlternativeFormatImportParts);
      //SetChartParts(openXmlElement, value?.ChartParts);
      SetCommentsIds(openXmlElement, value?.CommentsIds);
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
