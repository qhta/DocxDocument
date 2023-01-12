namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the DataModelExtensionBlock Class.
/// </summary>
public static class DataModelExtensionBlockConverter
{
  /// <summary>
  /// relId, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetRelId(DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock? openXmlElement)
  {
    return openXmlElement?.RelId?.Value;
  }
  
  public static void SetRelId(DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelId = new StringValue { Value = value };
      else
        openXmlElement.RelId = null;
  }
  
  /// <summary>
  /// minVer, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetMinVer(DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock? openXmlElement)
  {
    return openXmlElement?.MinVer?.Value;
  }
  
  public static void SetMinVer(DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinVer = new StringValue { Value = value };
      else
        openXmlElement.MinVer = null;
  }
  
  public static DocumentModel.Drawings.Office.DataModelExtensionBlock? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.DataModelExtensionBlock();
      value.RelId = GetRelId(openXmlElement);
      value.MinVer = GetMinVer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.DataModelExtensionBlock? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelId(openXmlElement, value?.RelId);
      SetMinVer(openXmlElement, value?.MinVer);
      return openXmlElement;
    }
    return default;
  }
}
