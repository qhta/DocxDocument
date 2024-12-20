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
    return openXmlElement?.Format?.Value;
  }
  
  private static bool CmpFormat(DXVT.VTClipboardData openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Format?.Value == value) return true;
    diffs?.Add(objName, "Custom", openXmlElement?.Format?.Value, value);
    return false;
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
    return openXmlElement?.Size?.Value;
  }
  
  private static bool CmpSize(DXVT.VTClipboardData openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Size?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Size?.Value, value);
    return false;
  }
  
  private static void SetSize(DXVT.VTClipboardData openXmlElement, UInt32? value)
  {
    openXmlElement.Size = value;
  }
  
  public static DocumentModel.VariantTypes.VTClipboardData? CreateModelElement(DXVT.VTClipboardData? openXmlElement)
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
  
  public static bool CompareModelElement(DXVT.VTClipboardData? openXmlElement, DMVT.VTClipboardData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormat(openXmlElement, value.Format, diffs, objName, propName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVT.VTClipboardData value)
    where OpenXmlElementType: DXVT.VTClipboardData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVT.VTClipboardData openXmlElement, DMVT.VTClipboardData value)
  {
    SetFormat(openXmlElement, value?.Format);
    SetSize(openXmlElement, value?.Size);
  }
}
