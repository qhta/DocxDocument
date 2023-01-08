namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public static class RelativeHeightConverter
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind? GetRelativeFrom(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  public static void SetRelativeFrom(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement, DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind>(value);
  }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  public static String? GetPercentageHeight(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight");
  }
  
  public static void SetPercentageHeight(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
