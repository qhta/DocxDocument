namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// New Shape Defaults.
/// </summary>
public static class ShapeDefaultsConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  public static Int32? GetMaxShapeId(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMaxShapeId(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// style
  /// </summary>
  public static String? GetStyle(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public static Boolean? GetBeFilled(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBeFilled(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  public static String? GetFillColor(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFillColor(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public static Boolean? GetIsStroke(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIsStroke(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public static String? GetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public static Boolean? GetAllowInCell(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowInCell(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowOverlap(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public static DocumentModel.Vml.InsetMarginKind? GetInsetMode(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  public static void SetInsetMode(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.InsetMarginKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public static DocumentModel.Vml.Fill? GetFill(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFill(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Fill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public static DocumentModel.Vml.ImageData? GetImageData(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetImageData(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.ImageData? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  public static DocumentModel.Vml.Stroke? GetStroke(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStroke(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Stroke? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  public static DocumentModel.Vml.TextBox? GetTextBox(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextBox(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.TextBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public static DocumentModel.Vml.Shadow? GetShadow(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShadow(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Shadow? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Skew.
  /// </summary>
  public static DocumentModel.Vml.Skew? GetSkew(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSkew(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Skew? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  public static DocumentModel.Vml.Extrusion? GetExtrusion(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtrusion(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Extrusion? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout.
  /// </summary>
  public static DocumentModel.Vml.Callout? GetCallout(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCallout(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Callout? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  public static DocumentModel.Vml.Lock? GetLock(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLock(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Lock? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public static DocumentModel.Vml.ColorMostRecentlyUsed? GetColorMostRecentlyUsed(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColorMostRecentlyUsed(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.ColorMostRecentlyUsed? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public static DocumentModel.Vml.ColorMenu? GetColorMenu(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColorMenu(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.ColorMenu? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
