namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CreationId Class.
/// </summary>
public static class CreationIdConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2016.Drawing.CreationId? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2016.Drawing.CreationId? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
