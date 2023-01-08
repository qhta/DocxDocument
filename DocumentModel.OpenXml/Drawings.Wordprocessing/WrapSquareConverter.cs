namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Square Wrapping.
/// </summary>
public static class WrapSquareConverter
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.WrapTextKind? GetWrapText(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DocumentModel.Drawings.Wordprocessing.WrapTextKind>(openXmlElement?.WrapText?.Value);
  }
  
  public static void SetWrapText(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DocumentModel.Drawings.Wordprocessing.WrapTextKind>(value);
  }
  
  /// <summary>
  /// Distance From Text (Top)
  /// </summary>
  public static UInt32? GetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? GetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, DocumentModel.Drawings.Wordprocessing.EffectExtent? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
