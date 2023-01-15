using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Packaging;
using DocumentModel.Wordprocessing;
using MainDocumentPart = DocumentFormat.OpenXml.Packaging.MainDocumentPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the MainDocumentPart
/// </summary>
public static class MainDocumentPartConverter
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public static Collection<AlternativeFormatImportPart>? GetAlternativeFormatImportParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public static Collection<ChartPart>? GetChartParts(MainDocumentPart? openXmlElement)
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

  /// <summary>
  ///   Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public static Collection<CustomXmlPart>? GetCustomXmlParts(MainDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CustomXmlPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomXmlPart>())
      {
        var newItem = CustomXmlPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public static Collection<DiagramColorsPart>? GetDiagramColorsParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public static Collection<DiagramDataPart>? GetDiagramDataParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public static Collection<DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public static Collection<DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public static Collection<DiagramStylePart>? GetDiagramStyleParts(MainDocumentPart? openXmlElement)
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
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Document? GetDocument(MainDocumentPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Document rootElement)
      return DocumentConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetDocument(MainDocumentPart? openXmlElement, Document? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = DocumentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Document>(value);
        if (rootElement != null)
          openXmlElement.Document = rootElement;
      }
  }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public static Collection<EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public static Collection<EmbeddedObjectPart>? GetEmbeddedObjectParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public static Collection<EmbeddedPackagePart>? GetEmbeddedPackageParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public static Collection<ExtendedChartPart>? GetExtendedChartParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public static Collection<FooterPart>? GetFooterParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public static Collection<HeaderPart>? GetHeaderParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(MainDocumentPart? openXmlElement)
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
  ///   Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public static Collection<Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(MainDocumentPart? openXmlElement)
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

  public static String? GetRelationshipType(MainDocumentPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public static Collection<WordprocessingPrinterSettingsPart>? GetWordprocessingPrinterSettingsParts(MainDocumentPart? openXmlElement)
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

  public static DocumentModel.Packaging.MainDocumentPart? CreateModelElement(MainDocumentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.MainDocumentPart();
      value.AlternativeFormatImportParts = GetAlternativeFormatImportParts(openXmlElement);
      value.ChartParts = GetChartParts(openXmlElement);
      value.CustomXmlParts = GetCustomXmlParts(openXmlElement);
      value.DiagramColorsParts = GetDiagramColorsParts(openXmlElement);
      value.DiagramDataParts = GetDiagramDataParts(openXmlElement);
      value.DiagramLayoutDefinitionParts = GetDiagramLayoutDefinitionParts(openXmlElement);
      value.DiagramPersistLayoutParts = GetDiagramPersistLayoutParts(openXmlElement);
      value.DiagramStyleParts = GetDiagramStyleParts(openXmlElement);
      value.Document = GetDocument(openXmlElement);
      value.EmbeddedControlPersistenceParts = GetEmbeddedControlPersistenceParts(openXmlElement);
      value.EmbeddedObjectParts = GetEmbeddedObjectParts(openXmlElement);
      value.EmbeddedPackageParts = GetEmbeddedPackageParts(openXmlElement);
      value.ExtendedChartParts = GetExtendedChartParts(openXmlElement);
      value.FooterParts = GetFooterParts(openXmlElement);
      value.HeaderParts = GetHeaderParts(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WordprocessingPrinterSettingsParts = GetWordprocessingPrinterSettingsParts(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.MainDocumentPart? value)
    where OpenXmlElementType : MainDocumentPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetAlternativeFormatImportParts(openXmlElement, value?.AlternativeFormatImportParts);
      //SetChartParts(openXmlElement, value?.ChartParts);
      //SetCustomXmlParts(openXmlElement, value?.CustomXmlParts);
      //SetDiagramColorsParts(openXmlElement, value?.DiagramColorsParts);
      //SetDiagramDataParts(openXmlElement, value?.DiagramDataParts);
      //SetDiagramLayoutDefinitionParts(openXmlElement, value?.DiagramLayoutDefinitionParts);
      //SetDiagramPersistLayoutParts(openXmlElement, value?.DiagramPersistLayoutParts);
      //SetDiagramStyleParts(openXmlElement, value?.DiagramStyleParts);
      SetDocument(openXmlElement, value?.Document);
      //SetEmbeddedControlPersistenceParts(openXmlElement, value?.EmbeddedControlPersistenceParts);
      //SetEmbeddedObjectParts(openXmlElement, value?.EmbeddedObjectParts);
      //SetEmbeddedPackageParts(openXmlElement, value?.EmbeddedPackageParts);
      //SetExtendedChartParts(openXmlElement, value?.ExtendedChartParts);
      //SetFooterParts(openXmlElement, value?.FooterParts);
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