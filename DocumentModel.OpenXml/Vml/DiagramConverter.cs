namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  public static Int32? GetStyle(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  public static Boolean? GetAutoFormat(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAutoFormat(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  public static Boolean? GetReverse(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetReverse(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  public static Boolean? GetAutoLayout(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAutoLayout(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  public static Int32? GetScaleX(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetScaleX(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  public static Int32? GetScaleY(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetScaleY(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  public static Int32? GetFontSize(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFontSize(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  public static String? GetConstrainBounds(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetConstrainBounds(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  public static Int32? GetBaseTextScale(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBaseTextScale(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  public static DocumentModel.Vml.RelationTable? GetRelationTable(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRelationTable(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, DocumentModel.Vml.RelationTable? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
