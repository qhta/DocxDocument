namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public static class GradientFillConverter
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  public static DocumentModel.Drawings.TileFlipKind? GetFlip(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DocumentModel.Drawings.TileFlipKind>(openXmlElement?.Flip?.Value);
  }
  
  public static void SetFlip(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.TileFlipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DocumentModel.Drawings.TileFlipKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRotateWithShape(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public static DocumentModel.Drawings.GradientStopList? GetGradientStopList(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGradientStopList(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.GradientStopList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LinearGradientFill? GetLinearGradientFill(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLinearGradientFill(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.LinearGradientFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PathGradientFill? GetPathGradientFill(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPathGradientFill(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.PathGradientFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.RelativeRectangleType? GetTileRectangle(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTileRectangle(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.RelativeRectangleType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
