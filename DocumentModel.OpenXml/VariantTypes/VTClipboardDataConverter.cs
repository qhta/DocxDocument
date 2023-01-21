namespace DocumentModel.OpenXml.VariantTypes;

/// <summary>
/// Clipboard Data.
/// </summary>
public static class VTClipboardDataConverter
{
  /// <summary>
  /// Format Attribute
  /// </summary>
  private static Int32? GetFormat(DXVT.VTClipboardData openXmlElement)
  {
    return openXmlElement.Format?.Value;
  }
  
  private static void SetFormat(DXVT.VTClipboardData openXmlElement, Int32? value)
  {
    openXmlElement.Format = value;
  }
  
  /// <summary>
  /// size
  /// </summary>
  private static UInt32? GetSize(DXVT.VTClipboardData openXmlElement)
  {
    return openXmlElement.Size?.Value;
  }
  
  private static void SetSize(DXVT.VTClipboardData openXmlElement, UInt32? value)
  {
    openXmlElement.Size = value;
  }
  
  public static DMVT.VTClipboardData? CreateModelElement(DXVT.VTClipboardData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVT.VTClipboardData();
      value.Format = GetFormat(openXmlElement);
      value.Size = GetSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVT.VTClipboardData? value)
    where OpenXmlElementType: DXVT.VTClipboardData, new()
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
