namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public static class PageSizeConverter
{
  /// <summary>
  /// Page Width
  /// </summary>
  public static UInt32? GetWidth(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Page Height
  /// </summary>
  public static UInt32? GetHeight(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Page Orientation
  /// </summary>
  public static DocumentModel.Wordprocessing.PageOrientationKind? GetOrient(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DocumentModel.Wordprocessing.PageOrientationKind>(openXmlElement?.Orient?.Value);
  }
  
  public static void SetOrient(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement, DocumentModel.Wordprocessing.PageOrientationKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Orient = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DocumentModel.Wordprocessing.PageOrientationKind>(value);
  }
  
  /// <summary>
  /// Printer Paper Code
  /// </summary>
  public static UInt16? GetCode(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement)
  {
    return openXmlElement?.Code?.Value;
  }
  
  public static void SetCode(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
      openXmlElement.Code = value;
  }
  
  public static DocumentModel.Wordprocessing.PageSize? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PageSize();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Orient = GetOrient(openXmlElement);
      value.Code = GetCode(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PageSize? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PageSize, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
