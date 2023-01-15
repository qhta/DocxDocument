using DocumentModel.Packaging;
using OpenXmlPartContainer = DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public static class OpenXmlPartContainerConverter
{
  /// <summary>
  ///   Gets all external relationships.
  /// </summary>
  public static Collection<ExternalRelationship>? GetExternalRelationships(OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ExternalRelationship>();
      foreach (var item in openXmlElement.ExternalRelationships)
      {
        var newItem = ExternalRelationshipConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets all hyperlink relationships.
  /// </summary>
  public static Collection<HyperlinkRelationship>? GetHyperlinkRelationships(OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<HyperlinkRelationship>();
      foreach (var item in openXmlElement.HyperlinkRelationships)
      {
        var newItem = HyperlinkRelationshipConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets all  relationships.
  /// </summary>
  public static Collection<DataPartReferenceRelationship>? GetDataPartReferenceRelationships(OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DataPartReferenceRelationship>();
      foreach (var item in openXmlElement.DataPartReferenceRelationships)
      {
        var newItem = DataPartReferenceRelationshipConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets all parts which are relationship targets of this part.
  /// </summary>
  public static Collection<IdPartPair>? GetParts(OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<IdPartPair>();
      foreach (var item in openXmlElement.Parts)
      {
        var newItem = IdPartPairConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static DocumentModel.Packaging.OpenXmlPartContainer? CreateModelElement(OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.OpenXmlPartContainer();
      value.ExternalRelationships = GetExternalRelationships(openXmlElement);
      value.HyperlinkRelationships = GetHyperlinkRelationships(openXmlElement);
      value.DataPartReferenceRelationships = GetDataPartReferenceRelationships(openXmlElement);
      value.Parts = GetParts(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.OpenXmlPartContainer? value)
    where OpenXmlElementType : OpenXmlPartContainer, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetExternalRelationships(openXmlElement, value?.ExternalRelationships);
      //SetHyperlinkRelationships(openXmlElement, value?.HyperlinkRelationships);
      //SetDataPartReferenceRelationships(openXmlElement, value?.DataPartReferenceRelationships);
      //SetParts(openXmlElement, value?.Parts);
      return openXmlElement;
    }
    return default;
  }
}