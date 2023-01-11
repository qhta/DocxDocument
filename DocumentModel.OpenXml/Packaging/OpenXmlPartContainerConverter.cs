namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public static class OpenXmlPartContainerConverter
{
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ExternalRelationship>? GetExternalRelationships(DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ExternalRelationship>();
      foreach (var item in openXmlElement.ExternalRelationships)
      {
        var newItem = DocumentModel.OpenXml.Packaging.ExternalRelationshipConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.HyperlinkRelationship>? GetHyperlinkRelationships(DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.HyperlinkRelationship>();
      foreach (var item in openXmlElement.HyperlinkRelationships)
      {
        var newItem = DocumentModel.OpenXml.Packaging.HyperlinkRelationshipConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DataPartReferenceRelationship>? GetDataPartReferenceRelationships(DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DataPartReferenceRelationship>();
      foreach (var item in openXmlElement.DataPartReferenceRelationships)
      {
        var newItem = DocumentModel.OpenXml.Packaging.DataPartReferenceRelationshipConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.IdPartPair>? GetParts(DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.IdPartPair>();
      foreach (var item in openXmlElement.Parts)
      {
        var newItem = DocumentModel.OpenXml.Packaging.IdPartPairConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static DocumentModel.Packaging.OpenXmlPartContainer? CreateModelElement(DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
