using DocumentModel.Packaging;
using SlideLayoutPart = DocumentFormat.OpenXml.Packaging.SlideLayoutPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the SlideLayoutPart
/// </summary>
public static class SlideLayoutPartConverter
{
  /// <summary>
  ///   Gets the ChartParts of the SlideLayoutPart
  /// </summary>
  public static Collection<ChartPart>? GetChartParts(SlideLayoutPart? openXmlElement)
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

  public static String? GetContentType(SlideLayoutPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the CustomXmlParts of the SlideLayoutPart
  /// </summary>
  public static Collection<CustomXmlPart>? GetCustomXmlParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the DiagramColorsParts of the SlideLayoutPart
  /// </summary>
  public static Collection<DiagramColorsPart>? GetDiagramColorsParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the DiagramDataParts of the SlideLayoutPart
  /// </summary>
  public static Collection<DiagramDataPart>? GetDiagramDataParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the DiagramLayoutDefinitionParts of the SlideLayoutPart
  /// </summary>
  public static Collection<DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the DiagramPersistLayoutParts of the SlideLayoutPart
  /// </summary>
  public static Collection<DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the DiagramStyleParts of the SlideLayoutPart
  /// </summary>
  public static Collection<DiagramStylePart>? GetDiagramStyleParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideLayoutPart
  /// </summary>
  public static Collection<EmbeddedControlPersistenceBinaryDataPart>? GetEmbeddedControlPersistenceBinaryDataParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the EmbeddedControlPersistenceParts of the SlideLayoutPart
  /// </summary>
  public static Collection<EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the EmbeddedObjectParts of the SlideLayoutPart
  /// </summary>
  public static Collection<EmbeddedObjectPart>? GetEmbeddedObjectParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the EmbeddedPackageParts of the SlideLayoutPart
  /// </summary>
  public static Collection<EmbeddedPackagePart>? GetEmbeddedPackageParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the ExtendedChartParts of the SlideLayoutPart
  /// </summary>
  public static Collection<ExtendedChartPart>? GetExtendedChartParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the ImageParts of the SlideLayoutPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(SlideLayoutPart? openXmlElement)
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
  ///   Gets the Model3DReferenceRelationshipParts of the SlideLayoutPart
  /// </summary>
  public static Collection<Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(SlideLayoutPart? openXmlElement)
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

  public static String? GetRelationshipType(SlideLayoutPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets the SlideParts of the SlideLayoutPart
  /// </summary>
  public static Collection<SlidePart>? GetSlideParts(SlideLayoutPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SlidePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlidePart>())
      {
        var newItem = SlidePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the UserDefinedTagsParts of the SlideLayoutPart
  /// </summary>
  public static Collection<UserDefinedTagsPart>? GetUserDefinedTagsParts(SlideLayoutPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<UserDefinedTagsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart>())
      {
        var newItem = UserDefinedTagsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets the VmlDrawingParts of the SlideLayoutPart
  /// </summary>
  public static Collection<VmlDrawingPart>? GetVmlDrawingParts(SlideLayoutPart? openXmlElement)
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

  public static DocumentModel.Packaging.SlideLayoutPart? CreateModelElement(SlideLayoutPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.SlideLayoutPart();
      value.ChartParts = GetChartParts(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.CustomXmlParts = GetCustomXmlParts(openXmlElement);
      value.DiagramColorsParts = GetDiagramColorsParts(openXmlElement);
      value.DiagramDataParts = GetDiagramDataParts(openXmlElement);
      value.DiagramLayoutDefinitionParts = GetDiagramLayoutDefinitionParts(openXmlElement);
      value.DiagramPersistLayoutParts = GetDiagramPersistLayoutParts(openXmlElement);
      value.DiagramStyleParts = GetDiagramStyleParts(openXmlElement);
      value.EmbeddedControlPersistenceBinaryDataParts = GetEmbeddedControlPersistenceBinaryDataParts(openXmlElement);
      value.EmbeddedControlPersistenceParts = GetEmbeddedControlPersistenceParts(openXmlElement);
      value.EmbeddedObjectParts = GetEmbeddedObjectParts(openXmlElement);
      value.EmbeddedPackageParts = GetEmbeddedPackageParts(openXmlElement);
      value.ExtendedChartParts = GetExtendedChartParts(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.SlideParts = GetSlideParts(openXmlElement);
      value.UserDefinedTagsParts = GetUserDefinedTagsParts(openXmlElement);
      value.VmlDrawingParts = GetVmlDrawingParts(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.SlideLayoutPart? value)
    where OpenXmlElementType : SlideLayoutPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetChartParts(openXmlElement, value?.ChartParts);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetCustomXmlParts(openXmlElement, value?.CustomXmlParts);
      //SetDiagramColorsParts(openXmlElement, value?.DiagramColorsParts);
      //SetDiagramDataParts(openXmlElement, value?.DiagramDataParts);
      //SetDiagramLayoutDefinitionParts(openXmlElement, value?.DiagramLayoutDefinitionParts);
      //SetDiagramPersistLayoutParts(openXmlElement, value?.DiagramPersistLayoutParts);
      //SetDiagramStyleParts(openXmlElement, value?.DiagramStyleParts);
      //SetEmbeddedControlPersistenceBinaryDataParts(openXmlElement, value?.EmbeddedControlPersistenceBinaryDataParts);
      //SetEmbeddedControlPersistenceParts(openXmlElement, value?.EmbeddedControlPersistenceParts);
      //SetEmbeddedObjectParts(openXmlElement, value?.EmbeddedObjectParts);
      //SetEmbeddedPackageParts(openXmlElement, value?.EmbeddedPackageParts);
      //SetExtendedChartParts(openXmlElement, value?.ExtendedChartParts);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetSlideParts(openXmlElement, value?.SlideParts);
      //SetUserDefinedTagsParts(openXmlElement, value?.UserDefinedTagsParts);
      //SetVmlDrawingParts(openXmlElement, value?.VmlDrawingParts);
      return openXmlElement;
    }
    return default;
  }
}