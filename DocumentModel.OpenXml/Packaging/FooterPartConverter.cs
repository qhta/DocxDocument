using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Packaging;
using DocumentModel.Wordprocessing;
using FooterPart = DocumentFormat.OpenXml.Packaging.FooterPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the FooterPart
/// </summary>
public static class FooterPartConverter
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the FooterPart
  /// </summary>
  public static Collection<AlternativeFormatImportPart>? GetAlternativeFormatImportParts(FooterPart? openXmlElement)
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
  ///   Gets the ChartParts of the FooterPart
  /// </summary>
  public static Collection<ChartPart>? GetChartParts(FooterPart? openXmlElement)
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

  public static String? GetContentType(FooterPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the DiagramColorsParts of the FooterPart
  /// </summary>
  public static Collection<DiagramColorsPart>? GetDiagramColorsParts(FooterPart? openXmlElement)
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
  ///   Gets the DiagramDataParts of the FooterPart
  /// </summary>
  public static Collection<DiagramDataPart>? GetDiagramDataParts(FooterPart? openXmlElement)
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
  ///   Gets the DiagramLayoutDefinitionParts of the FooterPart
  /// </summary>
  public static Collection<DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(FooterPart? openXmlElement)
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
  ///   Gets the DiagramPersistLayoutParts of the FooterPart
  /// </summary>
  public static Collection<DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(FooterPart? openXmlElement)
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
  ///   Gets the DiagramStyleParts of the FooterPart
  /// </summary>
  public static Collection<DiagramStylePart>? GetDiagramStyleParts(FooterPart? openXmlElement)
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
  ///   Gets the EmbeddedControlPersistenceParts of the FooterPart
  /// </summary>
  public static Collection<EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(FooterPart? openXmlElement)
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
  ///   Gets the EmbeddedObjectParts of the FooterPart
  /// </summary>
  public static Collection<EmbeddedObjectPart>? GetEmbeddedObjectParts(FooterPart? openXmlElement)
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
  ///   Gets the EmbeddedPackageParts of the FooterPart
  /// </summary>
  public static Collection<EmbeddedPackagePart>? GetEmbeddedPackageParts(FooterPart? openXmlElement)
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
  ///   Gets the ExtendedChartParts of the FooterPart
  /// </summary>
  public static Collection<ExtendedChartPart>? GetExtendedChartParts(FooterPart? openXmlElement)
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
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Footer? GetFooter(FooterPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Footer rootElement)
      return FooterConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetFooter(FooterPart? openXmlElement, Footer? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = FooterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Footer>(value);
        if (rootElement != null)
          openXmlElement.Footer = rootElement;
      }
  }

  /// <summary>
  ///   Gets the ImageParts of the FooterPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(FooterPart? openXmlElement)
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
  ///   Gets the Model3DReferenceRelationshipParts of the FooterPart
  /// </summary>
  public static Collection<Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(FooterPart? openXmlElement)
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

  public static String? GetRelationshipType(FooterPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.FooterPart? CreateModelElement(FooterPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.FooterPart();
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
      value.Footer = GetFooter(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.FooterPart? value)
    where OpenXmlElementType : FooterPart, new()
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
      SetFooter(openXmlElement, value?.Footer);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}