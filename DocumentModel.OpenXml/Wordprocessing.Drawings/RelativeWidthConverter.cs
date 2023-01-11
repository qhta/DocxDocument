namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public static class RelativeWidthConverter
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind? GetObjectId(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind>(openXmlElement?.ObjectId?.Value);
  }
  
  public static void SetObjectId(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth? openXmlElement, DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ObjectId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind>(value);
  }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  public static String? GetPercentageWidth(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth");
  }
  
  public static void SetPercentageWidth(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth");
  }
  
  public static DocumentModel.Wordprocessing.Drawings.RelativeWidth? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Drawings.RelativeWidth();
      value.ObjectId = GetObjectId(openXmlElement);
      value.PercentageWidth = GetPercentageWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Drawings.RelativeWidth? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
