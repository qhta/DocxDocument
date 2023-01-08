namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public static class CompatExtensionConverter
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetShapeId(DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetShapeId(DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
