namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Vertical Positioning.
/// </summary>
public static class VerticalPositionConverter
{
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind? GetRelativeFrom(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  public static void SetRelativeFrom(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement, DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Vertical Alignment.
  /// </summary>
  public static String? GetVerticalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment");
  }
  
  public static void SetVerticalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// PositionOffset.
  /// </summary>
  public static String? GetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset");
  }
  
  public static void SetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetPercentagePositionVerticalOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset");
  }
  
  public static void SetPercentagePositionVerticalOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
