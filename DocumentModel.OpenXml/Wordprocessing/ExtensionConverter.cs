namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
