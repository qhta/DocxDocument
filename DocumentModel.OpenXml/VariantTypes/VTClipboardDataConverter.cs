namespace DocumentModel.OpenXml.VariantTypes;

/// <summary>
/// Clipboard Data.
/// </summary>
public static class VTClipboardDataConverter
{
  /// <summary>
  /// Format Attribute
  /// </summary>
  private static Int32? GetFormat(DocumentFormat.OpenXml.VariantTypes.VTClipboardData openXmlElement)
  {
    return openXmlElement.Format?.Value;
  }
  
  private static void SetFormat(DocumentFormat.OpenXml.VariantTypes.VTClipboardData openXmlElement, Int32? value)
  {
    openXmlElement.Format = value;
  }
  
  /// <summary>
  /// size
  /// </summary>
  private static UInt32? GetSize(DocumentFormat.OpenXml.VariantTypes.VTClipboardData openXmlElement)
  {
    return openXmlElement.Size?.Value;
  }
  
  private static void SetSize(DocumentFormat.OpenXml.VariantTypes.VTClipboardData openXmlElement, UInt32? value)
  {
    openXmlElement.Size = value;
  }
  
  public static DocumentModel.VariantTypes.VTClipboardData? CreateModelElement(DocumentFormat.OpenXml.VariantTypes.VTClipboardData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.VariantTypes.VTClipboardData();
      value.Format = GetFormat(openXmlElement);
      value.Size = GetSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.VariantTypes.VTClipboardData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.VariantTypes.VTClipboardData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormat(openXmlElement, value?.Format);
      SetSize(openXmlElement, value?.Size);
      return openXmlElement;
    }
    return default;
  }
}
