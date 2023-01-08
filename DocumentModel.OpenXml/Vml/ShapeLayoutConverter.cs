namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public static class ShapeLayoutConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  public static DocumentModel.Vml.ShapeIdMap? GetShapeIdMap(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeIdMap(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement, DocumentModel.Vml.ShapeIdMap? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public static DocumentModel.Vml.RegroupTable? GetRegroupTable(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRegroupTable(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement, DocumentModel.Vml.RegroupTable? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public static DocumentModel.Vml.Rules? GetRules(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRules(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement, DocumentModel.Vml.Rules? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
