namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the GlossaryDocumentPart
/// </summary>
public static class GlossaryDocumentPartConverter
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? GetAlternativeFormatImportParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartPart>? GetChartParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramColorsPart>? GetDiagramColorsParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramDataPart>? GetDiagramDataParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramStylePart>? GetDiagramStyleParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedObjectPart>? GetEmbeddedObjectParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedPackagePart>? GetEmbeddedPackageParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ExtendedChartPart>? GetExtendedChartParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.FooterPart>? GetFooterParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.FooterPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FooterPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.FooterPartConverter.CreateModelElement(item);
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
  public static DocumentModel.Wordprocessing.GlossaryDocument? GetGlossaryDocument(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetGlossaryDocument(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement, DocumentModel.Wordprocessing.GlossaryDocument? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  /// <summary>
  /// Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.HeaderPart>? GetHeaderParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.HeaderPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.HeaderPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.HeaderPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  /// Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? GetWordprocessingPrinterSettingsParts(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.WordprocessingPrinterSettingsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static DocumentModel.Packaging.GlossaryDocumentPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.GlossaryDocumentPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGlossaryDocument(openXmlElement, value?.GlossaryDocument);
      return openXmlElement;
    }
    return default;
  }
}
