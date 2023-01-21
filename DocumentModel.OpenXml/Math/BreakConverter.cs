namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  private static Int64? GetAlignAt(DXMath.Break openXmlElement)
  {
    return openXmlElement.AlignAt?.Value;
  }
  
  private static void SetAlignAt(DXMath.Break openXmlElement, Int64? value)
  {
    openXmlElement.AlignAt = value;
  }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  private static Int64? GetVal(DXMath.Break openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DXMath.Break openXmlElement, Int64? value)
  {
    openXmlElement.Val = value;
  }
  
  public static DMMath.Break? CreateModelElement(DXMath.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Break();
      value.AlignAt = GetAlignAt(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Break? value)
    where OpenXmlElementType: DXMath.Break, new()
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
