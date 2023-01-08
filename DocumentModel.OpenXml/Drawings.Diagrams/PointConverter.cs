namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point.
/// </summary>
public static class PointConverter
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public static String? GetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.PointKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DocumentModel.Drawings.Diagrams.PointKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement, DocumentModel.Drawings.Diagrams.PointKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DocumentModel.Drawings.Diagrams.PointKind>(value);
  }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public static String? GetConnectionId(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetConnectionId(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.PropertySet? GetPropertySet(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPropertySet(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement, DocumentModel.Drawings.Diagrams.PropertySet? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement, DocumentModel.Drawings.Diagrams.ShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.TextBody? GetTextBody(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextBody(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement, DocumentModel.Drawings.Diagrams.TextBody? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.PtExtensionList? GetPtExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPtExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement, DocumentModel.Drawings.Diagrams.PtExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
