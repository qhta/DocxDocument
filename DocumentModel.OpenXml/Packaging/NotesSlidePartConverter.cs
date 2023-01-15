using DocumentModel.Packaging;
using NotesSlidePart = DocumentFormat.OpenXml.Packaging.NotesSlidePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the NotesSlidePart
/// </summary>
public static class NotesSlidePartConverter
{
  /// <summary>
  ///   Gets the ChartParts of the NotesSlidePart
  /// </summary>
  public static Collection<ChartPart>? GetChartParts(NotesSlidePart? openXmlElement)
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

  public static String? GetContentType(NotesSlidePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the CustomXmlParts of the NotesSlidePart
  /// </summary>
  public static Collection<CustomXmlPart>? GetCustomXmlParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the DiagramColorsParts of the NotesSlidePart
  /// </summary>
  public static Collection<DiagramColorsPart>? GetDiagramColorsParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the DiagramDataParts of the NotesSlidePart
  /// </summary>
  public static Collection<DiagramDataPart>? GetDiagramDataParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the DiagramLayoutDefinitionParts of the NotesSlidePart
  /// </summary>
  public static Collection<DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the DiagramPersistLayoutParts of the NotesSlidePart
  /// </summary>
  public static Collection<DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the DiagramStyleParts of the NotesSlidePart
  /// </summary>
  public static Collection<DiagramStylePart>? GetDiagramStyleParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesSlidePart
  /// </summary>
  public static Collection<EmbeddedControlPersistenceBinaryDataPart>? GetEmbeddedControlPersistenceBinaryDataParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the EmbeddedObjectParts of the NotesSlidePart
  /// </summary>
  public static Collection<EmbeddedObjectPart>? GetEmbeddedObjectParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the EmbeddedPackageParts of the NotesSlidePart
  /// </summary>
  public static Collection<EmbeddedPackagePart>? GetEmbeddedPackageParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the ExtendedChartParts of the NotesSlidePart
  /// </summary>
  public static Collection<ExtendedChartPart>? GetExtendedChartParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the ImageParts of the NotesSlidePart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the Model3DReferenceRelationshipParts of the NotesSlidePart
  /// </summary>
  public static Collection<Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(NotesSlidePart? openXmlElement)
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

  public static String? GetRelationshipType(NotesSlidePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets the UserDefinedTagsParts of the NotesSlidePart
  /// </summary>
  public static Collection<UserDefinedTagsPart>? GetUserDefinedTagsParts(NotesSlidePart? openXmlElement)
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
  ///   Gets the VmlDrawingParts of the NotesSlidePart
  /// </summary>
  public static Collection<VmlDrawingPart>? GetVmlDrawingParts(NotesSlidePart? openXmlElement)
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

  public static DocumentModel.Packaging.NotesSlidePart? CreateModelElement(NotesSlidePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.NotesSlidePart();
      value.ChartParts = GetChartParts(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.CustomXmlParts = GetCustomXmlParts(openXmlElement);
      value.DiagramColorsParts = GetDiagramColorsParts(openXmlElement);
      value.DiagramDataParts = GetDiagramDataParts(openXmlElement);
      value.DiagramLayoutDefinitionParts = GetDiagramLayoutDefinitionParts(openXmlElement);
      value.DiagramPersistLayoutParts = GetDiagramPersistLayoutParts(openXmlElement);
      value.DiagramStyleParts = GetDiagramStyleParts(openXmlElement);
      value.EmbeddedControlPersistenceBinaryDataParts = GetEmbeddedControlPersistenceBinaryDataParts(openXmlElement);
      value.EmbeddedObjectParts = GetEmbeddedObjectParts(openXmlElement);
      value.EmbeddedPackageParts = GetEmbeddedPackageParts(openXmlElement);
      value.ExtendedChartParts = GetExtendedChartParts(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Model3DReferenceRelationshipParts = GetModel3DReferenceRelationshipParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.UserDefinedTagsParts = GetUserDefinedTagsParts(openXmlElement);
      value.VmlDrawingParts = GetVmlDrawingParts(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.NotesSlidePart? value)
    where OpenXmlElementType : NotesSlidePart, new()
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
      //SetEmbeddedObjectParts(openXmlElement, value?.EmbeddedObjectParts);
      //SetEmbeddedPackageParts(openXmlElement, value?.EmbeddedPackageParts);
      //SetExtendedChartParts(openXmlElement, value?.ExtendedChartParts);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetModel3DReferenceRelationshipParts(openXmlElement, value?.Model3DReferenceRelationshipParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetUserDefinedTagsParts(openXmlElement, value?.UserDefinedTagsParts);
      //SetVmlDrawingParts(openXmlElement, value?.VmlDrawingParts);
      return openXmlElement;
    }
    return default;
  }
}