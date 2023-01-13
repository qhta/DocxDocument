namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlidePart
/// </summary>
public static class SlidePartConverter
{
  /// <summary>
  /// Gets the ChartParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartPart>? GetChartParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the commentParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.PowerPointCommentPart>? GetcommentParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.PowerPointCommentPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PowerPointCommentPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.PowerPointCommentPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.CustomXmlPart>? GetCustomXmlParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.CustomXmlPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomXmlPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.CustomXmlPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramColorsPart>? GetDiagramColorsParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the DiagramDataParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramDataPart>? GetDiagramDataParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the DiagramLayoutDefinitionParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? GetDiagramLayoutDefinitionParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the DiagramPersistLayoutParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? GetDiagramPersistLayoutParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the DiagramStyleParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DiagramStylePart>? GetDiagramStyleParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? GetEmbeddedControlPersistenceBinaryDataParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the EmbeddedControlPersistenceParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? GetEmbeddedControlPersistenceParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the EmbeddedObjectParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedObjectPart>? GetEmbeddedObjectParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the EmbeddedPackageParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedPackagePart>? GetEmbeddedPackageParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the ExtendedChartParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ExtendedChartPart>? GetExtendedChartParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the ImageParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the Model3DReferenceRelationshipParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? GetModel3DReferenceRelationshipParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the SlideParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SlidePart>? GetSlideParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SlidePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlidePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.SlidePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.UserDefinedTagsPart>? GetUserDefinedTagsParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.UserDefinedTagsPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.UserDefinedTagsPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.VmlDrawingPart>? GetVmlDrawingParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
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
  /// Gets the WebExtensionParts of the SlidePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WebExtensionPart>? GetWebExtensionParts(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WebExtensionPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WebExtensionPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.WebExtensionPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static DocumentModel.Packaging.SlidePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.SlidePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.SlidePart();
      value.ChartParts = GetChartParts(openXmlElement);
      value.commentParts = GetcommentParts(openXmlElement);
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
      value.WebExtensionParts = GetWebExtensionParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.SlidePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.SlidePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetChartParts(openXmlElement, value?.ChartParts);
      //SetcommentParts(openXmlElement, value?.commentParts);
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
      //SetWebExtensionParts(openXmlElement, value?.WebExtensionParts);
      return openXmlElement;
    }
    return default;
  }
}
