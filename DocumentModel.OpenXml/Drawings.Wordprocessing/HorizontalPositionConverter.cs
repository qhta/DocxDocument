namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public static class HorizontalPositionConverter
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind? GetRelativeFrom(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  public static void SetRelativeFrom(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement, DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  public static String? GetHorizontalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment");
  }
  
  public static void SetHorizontalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment");
  }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  public static String? GetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset");
  }
  
  public static void SetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset");
  }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetPercentagePositionHeightOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset");
  }
  
  public static void SetPercentagePositionHeightOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset");
  }
  
  public static DocumentModel.Drawings.Wordprocessing.HorizontalPosition? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.HorizontalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.HorizontalAlignment = GetHorizontalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionHeightOffset = GetPercentagePositionHeightOffset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.HorizontalPosition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
