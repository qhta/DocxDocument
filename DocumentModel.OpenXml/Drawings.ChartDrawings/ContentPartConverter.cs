namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public static class ContentPartConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetRelationshipId(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetRelationshipId(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Drawings.BlackWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  public static void SetBlackWhiteMode(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? GetNonVisualContentPartProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNonVisualContentPartProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? GetApplicationNonVisualDrawingProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetApplicationNonVisualDrawingProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Transform2D? GetTransform2D(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTransform2D(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.Transform2D? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
