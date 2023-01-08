namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public static class PathGradientFillConverter
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public static DocumentModel.Drawings.PathShadeKind? GetPath(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DocumentModel.Drawings.PathShadeKind>(openXmlElement?.Path?.Value);
  }
  
  public static void SetPath(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement, DocumentModel.Drawings.PathShadeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Path = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DocumentModel.Drawings.PathShadeKind>(value);
  }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public static DocumentModel.Drawings.RelativeRectangleType? GetFillToRectangle(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFillToRectangle(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement, DocumentModel.Drawings.RelativeRectangleType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
