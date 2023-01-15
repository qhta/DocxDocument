using DocumentFormat.OpenXml.Math;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  ///   Index of Operator to Align To
  /// </summary>
  public static Int64? GetAlignAt(Break? openXmlElement)
  {
    return openXmlElement?.AlignAt?.Value;
  }

  public static void SetAlignAt(Break? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.AlignAt = value;
  }

  /// <summary>
  ///   Index of Operator to Align To
  /// </summary>
  public static Int64? GetVal(Break? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(Break? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }

  public static DocumentModel.Math.Break? CreateModelElement(Break? openXmlElement)
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
    where OpenXmlElementType : Break, new()
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