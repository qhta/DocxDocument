namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public static class OpenXmlPartContainerConverter
{
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  private static Collection<DMPack.ExternalRelationship> GetExternalRelationships(DXPack.OpenXmlPartContainer openXmlElement)
  {
    var collection = new Collection<DMPack.ExternalRelationship>();
    foreach (var item in openXmlElement.ExternalRelationships)
    {
      var newItem = DMXPack.ExternalRelationshipConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  private static Collection<DMPack.HyperlinkRelationship> GetHyperlinkRelationships(DXPack.OpenXmlPartContainer openXmlElement)
  {
    var collection = new Collection<DMPack.HyperlinkRelationship>();
    foreach (var item in openXmlElement.HyperlinkRelationships)
    {
      var newItem = DMXPack.HyperlinkRelationshipConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  private static Collection<DMPack.DataPartReferenceRelationship> GetDataPartReferenceRelationships(DXPack.OpenXmlPartContainer openXmlElement)
  {
    var collection = new Collection<DMPack.DataPartReferenceRelationship>();
    foreach (var item in openXmlElement.DataPartReferenceRelationships)
    {
      var newItem = DMXPack.DataPartReferenceRelationshipConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  private static Collection<DMPack.IdPartPair> GetParts(DXPack.OpenXmlPartContainer openXmlElement)
  {
    var collection = new Collection<DMPack.IdPartPair>();
    foreach (var item in openXmlElement.Parts)
    {
      var newItem = DMXPack.IdPartPairConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  public static DMPack.OpenXmlPartContainer? CreateModelElement(DXPack.OpenXmlPartContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.OpenXmlPartContainer();
      value.ExternalRelationships = GetExternalRelationships(openXmlElement);
      value.HyperlinkRelationships = GetHyperlinkRelationships(openXmlElement);
      value.DataPartReferenceRelationships = GetDataPartReferenceRelationships(openXmlElement);
      value.Parts = GetParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.OpenXmlPartContainer? value)
    where OpenXmlElementType: DXPack.OpenXmlPartContainer, new()
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
