namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Layout Node.
/// </summary>
public static class LayoutNodeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Style Label
  /// </summary>
  public static String? GetStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Child Order
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ChildOrderKind? GetChildOrder(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DocumentModel.Drawings.Diagrams.ChildOrderKind>(openXmlElement?.ChildOrder?.Value);
  }
  
  public static void SetChildOrder(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.ChildOrderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ChildOrder = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DocumentModel.Drawings.Diagrams.ChildOrderKind>(value);
  }
  
  /// <summary>
  /// Move With
  /// </summary>
  public static String? GetMoveWith(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetMoveWith(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.Algorithm? GetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.Algorithm? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.Shape? GetShape(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.Shape? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.PresentationOf? GetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.PresentationOf? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.Constraints? GetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.Constraints? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.RuleList? GetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.RuleList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.VariableList? GetVariableList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVariableList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.VariableList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.ForEach? GetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.ForEach? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutNode? GetChildLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChildLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.LayoutNode? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.Choose? GetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.Choose? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
