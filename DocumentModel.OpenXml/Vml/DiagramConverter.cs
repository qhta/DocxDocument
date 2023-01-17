namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  private static Int64? GetStyle(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement.Style?.Value;
  }
  
  private static void SetStyle(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.Style = value;
  }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  private static Boolean? GetAutoFormat(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement?.AutoFormat?.Value;
  }
  
  private static void SetAutoFormat(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoFormat = value;
    else
      openXmlElement.AutoFormat = null;
  }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  private static Boolean? GetReverse(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement?.Reverse?.Value;
  }
  
  private static void SetReverse(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Reverse = value;
    else
      openXmlElement.Reverse = null;
  }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  private static Boolean? GetAutoLayout(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement?.AutoLayout?.Value;
  }
  
  private static void SetAutoLayout(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoLayout = value;
    else
      openXmlElement.AutoLayout = null;
  }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  private static Int64? GetScaleX(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement.ScaleX?.Value;
  }
  
  private static void SetScaleX(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.ScaleX = value;
  }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  private static Int64? GetScaleY(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement.ScaleY?.Value;
  }
  
  private static void SetScaleY(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.ScaleY = value;
  }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  private static Int64? GetFontSize(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement.FontSize?.Value;
  }
  
  private static void SetFontSize(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  private static String? GetConstrainBounds(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement?.ConstrainBounds?.Value;
  }
  
  private static void SetConstrainBounds(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ConstrainBounds = new StringValue { Value = value };
    else
      openXmlElement.ConstrainBounds = null;
  }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  private static Int64? GetBaseTextScale(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    return openXmlElement.BaseTextScale?.Value;
  }
  
  private static void SetBaseTextScale(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.BaseTextScale = value;
  }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  private static DocumentModel.Vml.RelationTable? GetRelationTable(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RelationTable>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RelationTableConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRelationTable(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement, DocumentModel.Vml.RelationTable? value)
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
