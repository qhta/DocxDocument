namespace DocumentModel.OpenXml.VariantTypes;

/// <summary>
///   Clipboard Data.
/// </summary>
public static class VTClipboardDataConverter
{
  /// <summary>
  ///   Format Attribute
  /// </summary>
  public static Int32? GetFormat(VTClipboardData? openXmlElement)
  {
    return openXmlElement?.Format?.Value;
  }

  public static void SetFormat(VTClipboardData? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Format = value;
  }

  /// <summary>
  ///   size
  /// </summary>
  public static UInt32? GetSize(VTClipboardData? openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }

  public static void SetSize(VTClipboardData? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Size = value;
  }

  public static DocumentModel.VariantTypes.VTClipboardData? CreateModelElement(VTClipboardData? openXmlElement)
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
    where OpenXmlElementType : VTClipboardData, new()
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