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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Page Height
  /// </summary>
  public static UInt32? GetHeight(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCode(DocumentFormat.OpenXml.Wordprocessing.PageSize? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
