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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeIdMapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeIdMap(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement, DocumentModel.Vml.ShapeIdMap? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ShapeIdMapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public static DocumentModel.Vml.RegroupTable? GetRegroupTable(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RegroupTable>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RegroupTableConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRegroupTable(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement, DocumentModel.Vml.RegroupTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RegroupTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.RegroupTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.RegroupTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public static DocumentModel.Vml.Rules? GetRules(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Rules>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RulesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRules(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement, DocumentModel.Vml.Rules? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Rules>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.RulesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Rules>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.ShapeLayout? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.ShapeLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeLayout();
      value.Extension = GetExtension(openXmlElement);
      value.ShapeIdMap = GetShapeIdMap(openXmlElement);
      value.RegroupTable = GetRegroupTable(openXmlElement);
      value.Rules = GetRules(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ShapeLayout? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.ShapeLayout, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
