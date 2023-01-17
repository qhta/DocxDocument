namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  private static Int64? GetAlignAt(DocumentFormat.OpenXml.Math.Break openXmlElement)
  {
    return openXmlElement.AlignAt?.Value;
  }
  
  private static void SetAlignAt(DocumentFormat.OpenXml.Math.Break openXmlElement, Int64? value)
  {
    openXmlElement.AlignAt = value;
  }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  private static Int64? GetVal(DocumentFormat.OpenXml.Math.Break openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Math.Break openXmlElement, Int64? value)
  {
    openXmlElement.Val = value;
  }
  
  public static DocumentModel.Math.Break? CreateModelElement(DocumentFormat.OpenXml.Math.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Break();
      value.AlignAt = GetAlignAt(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Break? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Break, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignAt(openXmlElement, value?.AlignAt);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
