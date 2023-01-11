namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines a reference relationship. A reference relationship can be internal or external.
/// </summary>
public static class ReferenceRelationshipConverter
{
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static void SetRelationshipType(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets a value indicating whether the target of the relationship is Internal or External to the .
  /// </summary>
  public static Boolean? GetIsExternal(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is System.Boolean");
  }
  
  public static void SetIsExternal(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is System.Boolean");
  }
  
  /// <summary>
  /// Gets the relationship ID.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the target URI of the relationship.
  /// </summary>
  public static Uri? GetUri(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement, Uri? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static DocumentModel.Packaging.ReferenceRelationship? CreateModelElement(DocumentFormat.OpenXml.Packaging.ReferenceRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ReferenceRelationship();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.IsExternal = GetIsExternal(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ReferenceRelationship? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ReferenceRelationship, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
