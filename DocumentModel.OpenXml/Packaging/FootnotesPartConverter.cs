namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the FootnotesPart
/// </summary>
public static class FootnotesPartConverter
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.AlternativeFormatImportPart> GetAlternativeFormatImportParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the ChartParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartPart> GetChartParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramColorsPart> GetDiagramColorsParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the DiagramDataParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramDataPart> GetDiagramDataParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart> GetDiagramLayoutDefinitionParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramPersistLayoutPart> GetDiagramPersistLayoutParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the DiagramStyleParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramStylePart> GetDiagramStyleParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart> GetEmbeddedControlPersistenceParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedObjectPart> GetEmbeddedObjectParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedPackagePart> GetEmbeddedPackageParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the ExtendedChartParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ExtendedChartPart> GetExtendedChartParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Wordprocessing.Footnotes? GetFootnotes(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Footnotes rootElement)
      return DocumentModel.OpenXml.Wordprocessing.FootnotesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetFootnotes(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement, DocumentModel.Wordprocessing.Footnotes? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Wordprocessing.FootnotesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Footnotes>(value);
       if (rootElement != null)
         openXmlElement.Footnotes = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart> GetImageParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the FootnotesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart> GetModel3DReferenceRelationshipParts(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
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
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.FootnotesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.FootnotesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.FootnotesPart();
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
      value.Footnotes = GetFootnotes(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.FootnotesPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.FootnotesPart, new()
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
      SetFootnotes(openXmlElement, value?.Footnotes);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
