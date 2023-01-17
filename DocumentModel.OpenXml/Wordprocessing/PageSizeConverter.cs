namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public static class PageSizeConverter
{
  /// <summary>
  /// Page Width
  /// </summary>
  private static UInt32? GetWidth(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement, UInt32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Page Height
  /// </summary>
  private static UInt32? GetHeight(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Page Orientation
  /// </summary>
  private static DocumentModel.Wordprocessing.PageOrientationKind? GetOrient(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DocumentModel.Wordprocessing.PageOrientationKind>(openXmlElement?.Orient?.Value);
  }
  
  private static void SetOrient(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement, DocumentModel.Wordprocessing.PageOrientationKind? value)
  {
    openXmlElement.Orient = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DocumentModel.Wordprocessing.PageOrientationKind>(value);
  }
  
  /// <summary>
  /// Printer Paper Code
  /// </summary>
  private static UInt16? GetCode(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement)
  {
    return openXmlElement.Code?.Value;
  }
  
  private static void SetCode(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement, UInt16? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetOrient(openXmlElement, value?.Orient);
      SetCode(openXmlElement, value?.Code);
      return openXmlElement;
    }
    return default;
  }
}
