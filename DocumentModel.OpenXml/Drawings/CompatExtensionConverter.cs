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
    return openXmlElement?.ShapeId?.Value;
  }
  
  public static void SetShapeId(DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeId = new StringValue { Value = value };
      else
        openXmlElement.ShapeId = null;
  }
  
  public static DocumentModel.Drawings.CompatExtension? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CompatExtension();
      value.ShapeId = GetShapeId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CompatExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeId(openXmlElement, value?.ShapeId);
      return openXmlElement;
    }
    return default;
  }
}
