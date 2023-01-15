using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Packaging;
using DocumentModel.Wordprocessing;
using GlossaryDocumentPart = DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the GlossaryDocumentPart
/// </summary>
public static class GlossaryDocumentPartConverter
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<AlternativeFormatImportPart>? GetAlternativeFormatImportParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AlternativeFormatImportPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>())
      {
        var newItem = AlternativeFormatImportPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<ChartPart>? GetChartParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ChartPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartPart>())
      {
        var newItem = ChartPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static String? GetContentType(GlossaryDocumentPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<DiagramColorsPart>? GetDiagramColorsParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DiagramColorsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>())
      {
        var newItem = DiagramColorsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<DiagramDataPart>? GetDiagramDataParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DiagramDataPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramDataPart>())
      {
        var newItem = DiagramDataPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DiagramLayoutDefinitionPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>())
      {
        var newItem = DiagramLayoutDefinitionPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DiagramPersistLayoutPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>())
      {
        var newItem = DiagramPersistLayoutPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<DiagramStylePart>? GetDiagramStyleParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DiagramStylePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramStylePart>())
      {
        var newItem = DiagramStylePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(GlossaryDocumentPart? openXmlElement)
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
  ///   Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<EmbeddedObjectPart>? GetEmbeddedObjectParts(GlossaryDocumentPart? openXmlElement)
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
  ///   Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<EmbeddedPackagePart>? GetEmbeddedPackageParts(GlossaryDocumentPart? openXmlElement)
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
  ///   Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<ExtendedChartPart>? GetExtendedChartParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ExtendedChartPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>())
      {
        var newItem = ExtendedChartPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<FooterPart>? GetFooterParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<FooterPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FooterPart>())
      {
        var newItem = FooterPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static GlossaryDocument? GetGlossaryDocument(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument rootElement)
      return GlossaryDocumentConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetGlossaryDocument(GlossaryDocumentPart? openXmlElement, GlossaryDocument? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = GlossaryDocumentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument>(value);
        if (rootElement != null)
          openXmlElement.GlossaryDocument = rootElement;
      }
  }

  /// <summary>
  ///   Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<HeaderPart>? GetHeaderParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<HeaderPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.HeaderPart>())
      {
        var newItem = HeaderPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(GlossaryDocumentPart? openXmlElement)
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
  ///   Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(GlossaryDocumentPart? openXmlElement)
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

  public static String? GetRelationshipType(GlossaryDocumentPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public static Collection<WordprocessingPrinterSettingsPart>? GetWordprocessingPrinterSettingsParts(GlossaryDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<WordprocessingPrinterSettingsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart>())
      {
        var newItem = WordprocessingPrinterSettingsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static DocumentModel.Packaging.GlossaryDocumentPart? CreateModelElement(GlossaryDocumentPart? openXmlElement)
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
    where OpenXmlElementType : GlossaryDocumentPart, new()
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