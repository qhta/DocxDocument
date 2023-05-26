namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public static class OpenXmlPartContainerConverter
{
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  private static Collection<DMPack.ExternalRelationship>? GetExternalRelationships(DXPack.OpenXmlPartContainer openXmlElement)
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
  
  private static bool CmpExternalRelationships(DXPack.OpenXmlPartContainer openXmlElement, Collection<DMPack.ExternalRelationship>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  private static Collection<DMPack.HyperlinkRelationship>? GetHyperlinkRelationships(DXPack.OpenXmlPartContainer openXmlElement)
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
  
  private static bool CmpHyperlinkRelationships(DXPack.OpenXmlPartContainer openXmlElement, Collection<DMPack.HyperlinkRelationship>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  private static Collection<DMPack.DataPartReferenceRelationship>? GetDataPartReferenceRelationships(DXPack.OpenXmlPartContainer openXmlElement)
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
  
  private static bool CmpDataPartReferenceRelationships(DXPack.OpenXmlPartContainer openXmlElement, Collection<DMPack.DataPartReferenceRelationship>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  private static Collection<DMPack.IdPartPair>? GetParts(DXPack.OpenXmlPartContainer openXmlElement)
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
  
  private static bool CmpParts(DXPack.OpenXmlPartContainer openXmlElement, Collection<DMPack.IdPartPair>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  public static DocumentModel.Packaging.OpenXmlPartContainer? CreateModelElement(DXPack.OpenXmlPartContainer? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.OpenXmlPartContainer? openXmlElement, DMPack.OpenXmlPartContainer? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExternalRelationships(openXmlElement, value.ExternalRelationships, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlinkRelationships(openXmlElement, value.HyperlinkRelationships, diffs, objName, propName))
        ok = false;
      if (!CmpDataPartReferenceRelationships(openXmlElement, value.DataPartReferenceRelationships, diffs, objName, propName))
        ok = false;
      if (!CmpParts(openXmlElement, value.Parts, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.OpenXmlPartContainer value)
    where OpenXmlElementType: DXPack.OpenXmlPartContainer, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.OpenXmlPartContainer openXmlElement, DMPack.OpenXmlPartContainer value)
  {
    //SetExternalRelationships(openXmlElement, value?.ExternalRelationships);
    //SetHyperlinkRelationships(openXmlElement, value?.HyperlinkRelationships);
    //SetDataPartReferenceRelationships(openXmlElement, value?.DataPartReferenceRelationships);
    //SetParts(openXmlElement, value?.Parts);
  }
}
