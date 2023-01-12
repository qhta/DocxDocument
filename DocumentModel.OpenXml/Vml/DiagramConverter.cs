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
  public static Int64? GetStyle(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Style = value;
  }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  public static Boolean? GetAutoFormat(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAutoFormat(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  public static Boolean? GetReverse(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetReverse(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  public static Boolean? GetAutoLayout(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAutoLayout(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  public static Int64? GetScaleX(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    return openXmlElement?.ScaleX?.Value;
  }
  
  public static void SetScaleX(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ScaleX = value;
  }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  public static Int64? GetScaleY(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    return openXmlElement?.ScaleY?.Value;
  }
  
  public static void SetScaleY(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ScaleY = value;
  }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  public static Int64? GetFontSize(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }
  
  public static void SetFontSize(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  public static String? GetConstrainBounds(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    return openXmlElement?.ConstrainBounds?.Value;
  }
  
  public static void SetConstrainBounds(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ConstrainBounds = new StringValue { Value = value };
      else
        openXmlElement.ConstrainBounds = null;
  }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  public static Int64? GetBaseTextScale(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    return openXmlElement?.BaseTextScale?.Value;
  }
  
  public static void SetBaseTextScale(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BaseTextScale = value;
  }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  public static DocumentModel.Vml.RelationTable? GetRelationTable(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RelationTable>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RelationTableConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRelationTable(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement, DocumentModel.Vml.RelationTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RelationTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.RelationTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.RelationTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Diagram? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Diagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Diagram();
      value.Extension = GetExtension(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.AutoFormat = GetAutoFormat(openXmlElement);
      value.Reverse = GetReverse(openXmlElement);
      value.AutoLayout = GetAutoLayout(openXmlElement);
      value.ScaleX = GetScaleX(openXmlElement);
      value.ScaleY = GetScaleY(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      value.ConstrainBounds = GetConstrainBounds(openXmlElement);
      value.BaseTextScale = GetBaseTextScale(openXmlElement);
      value.RelationTable = GetRelationTable(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Diagram? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Diagram, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetStyle(openXmlElement, value?.Style);
      SetAutoFormat(openXmlElement, value?.AutoFormat);
      SetReverse(openXmlElement, value?.Reverse);
      SetAutoLayout(openXmlElement, value?.AutoLayout);
      SetScaleX(openXmlElement, value?.ScaleX);
      SetScaleY(openXmlElement, value?.ScaleY);
      SetFontSize(openXmlElement, value?.FontSize);
      SetConstrainBounds(openXmlElement, value?.ConstrainBounds);
      SetBaseTextScale(openXmlElement, value?.BaseTextScale);
      SetRelationTable(openXmlElement, value?.RelationTable);
      return openXmlElement;
    }
    return default;
  }
}
