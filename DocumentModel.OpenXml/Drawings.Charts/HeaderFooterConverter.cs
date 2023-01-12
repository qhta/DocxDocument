namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Header and Footer.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  /// Align With Margins
  /// </summary>
  public static Boolean? GetAlignWithMargins(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    return openXmlElement?.AlignWithMargins?.Value;
  }
  
  public static void SetAlignWithMargins(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AlignWithMargins = null;
  }
  
  /// <summary>
  /// Different Odd Even
  /// </summary>
  public static Boolean? GetDifferentOddEven(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    return openXmlElement?.DifferentOddEven?.Value;
  }
  
  public static void SetDifferentOddEven(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.DifferentOddEven = null;
  }
  
  /// <summary>
  /// Different First
  /// </summary>
  public static Boolean? GetDifferentFirst(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    return openXmlElement?.DifferentFirst?.Value;
  }
  
  public static void SetDifferentFirst(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.DifferentFirst = null;
  }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  public static String? GetOddHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.OddHeader");
  }
  
  public static void SetOddHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.OddHeader");
  }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  public static String? GetOddFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.OddFooter");
  }
  
  public static void SetOddFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.OddFooter");
  }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  public static String? GetEvenHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.EvenHeader");
  }
  
  public static void SetEvenHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.EvenHeader");
  }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  public static String? GetEvenFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.EvenFooter");
  }
  
  public static void SetEvenFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.EvenFooter");
  }
  
  /// <summary>
  /// First Header.
  /// </summary>
  public static String? GetFirstHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FirstHeader");
  }
  
  public static void SetFirstHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FirstHeader");
  }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  public static String? GetFirstFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FirstFooter");
  }
  
  public static void SetFirstFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FirstFooter");
  }
  
  public static DocumentModel.Drawings.Charts.HeaderFooter? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.HeaderFooter();
      value.AlignWithMargins = GetAlignWithMargins(openXmlElement);
      value.DifferentOddEven = GetDifferentOddEven(openXmlElement);
      value.DifferentFirst = GetDifferentFirst(openXmlElement);
      value.OddHeader = GetOddHeader(openXmlElement);
      value.OddFooter = GetOddFooter(openXmlElement);
      value.EvenHeader = GetEvenHeader(openXmlElement);
      value.EvenFooter = GetEvenFooter(openXmlElement);
      value.FirstHeader = GetFirstHeader(openXmlElement);
      value.FirstFooter = GetFirstFooter(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.HeaderFooter? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignWithMargins(openXmlElement, value?.AlignWithMargins);
      SetDifferentOddEven(openXmlElement, value?.DifferentOddEven);
      SetDifferentFirst(openXmlElement, value?.DifferentFirst);
      SetOddHeader(openXmlElement, value?.OddHeader);
      SetOddFooter(openXmlElement, value?.OddFooter);
      SetEvenHeader(openXmlElement, value?.EvenHeader);
      SetEvenFooter(openXmlElement, value?.EvenFooter);
      SetFirstHeader(openXmlElement, value?.FirstHeader);
      SetFirstFooter(openXmlElement, value?.FirstFooter);
      return openXmlElement;
    }
    return default;
  }
}
