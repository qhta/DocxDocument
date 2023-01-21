namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RelationshipType Class.
/// </summary>
public static class RelationshipTypeConverter
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetId(DXW.RelationshipType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.RelationshipType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.RelationshipType? CreateModelElement(DXW.RelationshipType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RelationshipType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RelationshipType? value)
    where OpenXmlElementType: DXW.RelationshipType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
