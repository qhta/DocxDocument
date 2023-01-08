namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
public static class PageBordersConverter
{
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  public static DocumentModel.Wordprocessing.PageBorderZOrderKind? GetZOrder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues, DocumentModel.Wordprocessing.PageBorderZOrderKind>(openXmlElement?.ZOrder?.Value);
  }
  
  public static void SetZOrder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.PageBorderZOrderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ZOrder = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues, DocumentModel.Wordprocessing.PageBorderZOrderKind>(value);
  }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  public static DocumentModel.Wordprocessing.PageBorderDisplayKind? GetDisplay(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues, DocumentModel.Wordprocessing.PageBorderDisplayKind>(openXmlElement?.Display?.Value);
  }
  
  public static void SetDisplay(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.PageBorderDisplayKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Display = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues, DocumentModel.Wordprocessing.PageBorderDisplayKind>(value);
  }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  public static DocumentModel.Wordprocessing.PageBorderOffsetKind? GetOffsetFrom(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues, DocumentModel.Wordprocessing.PageBorderOffsetKind>(openXmlElement?.OffsetFrom?.Value);
  }
  
  public static void SetOffsetFrom(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.PageBorderOffsetKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.OffsetFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues, DocumentModel.Wordprocessing.PageBorderOffsetKind>(value);
  }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetTopBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTopBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetRightBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRightBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
