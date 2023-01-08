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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment");
  }
  
  public static void SetHorizontalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  public static String? GetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset");
  }
  
  public static void SetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetPercentagePositionHeightOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset");
  }
  
  public static void SetPercentagePositionHeightOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
