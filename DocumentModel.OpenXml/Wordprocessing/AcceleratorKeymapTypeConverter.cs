namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AcceleratorKeymapType Class.
/// </summary>
public static class AcceleratorKeymapTypeConverter
{
  /// <summary>
  /// acdName
  /// </summary>
  public static String? GetAcceleratorName(DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType? openXmlElement)
  {
    return openXmlElement?.AcceleratorName?.Value;
  }
  
  public static void SetAcceleratorName(DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AcceleratorName = new StringValue { Value = value };
      else
        openXmlElement.AcceleratorName = null;
  }
  
  public static DocumentModel.Wordprocessing.AcceleratorKeymapType? CreateModelElement(DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AcceleratorKeymapType();
      value.AcceleratorName = GetAcceleratorName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AcceleratorKeymapType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
