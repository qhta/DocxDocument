namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Relative Offset Effect.
/// </summary>
public static class RelativeOffsetConverter
{
  /// <summary>
  /// Offset X
  /// </summary>
  public static Int32? GetOffsetX(DocumentFormat.OpenXml.Drawing.RelativeOffset? openXmlElement)
  {
    return openXmlElement?.OffsetX?.Value;
  }
  
  public static void SetOffsetX(DocumentFormat.OpenXml.Drawing.RelativeOffset? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OffsetX = value;
  }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  public static Int32? GetOffsetY(DocumentFormat.OpenXml.Drawing.RelativeOffset? openXmlElement)
  {
    return openXmlElement?.OffsetY?.Value;
  }
  
  public static void SetOffsetY(DocumentFormat.OpenXml.Drawing.RelativeOffset? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OffsetY = value;
  }
  
  public static DocumentModel.Drawings.RelativeOffset? CreateModelElement(DocumentFormat.OpenXml.Drawing.RelativeOffset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RelativeOffset();
      value.OffsetX = GetOffsetX(openXmlElement);
      value.OffsetY = GetOffsetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.RelativeOffset? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.RelativeOffset, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
