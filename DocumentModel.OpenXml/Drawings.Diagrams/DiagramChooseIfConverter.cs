namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// If.
/// </summary>
public static class DiagramChooseIfConverter
{
  /// <summary>
  /// Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public static DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? GetAxis(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxis(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public static DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? GetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public static DocumentModel.ListOf<Boolean>? GetHideLastTrans(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHideLastTrans(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<Boolean>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public static DocumentModel.ListOf<Int32>? GetStart(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStart(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<Int32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public static DocumentModel.ListOf<UInt32>? GetCount(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCount(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public static DocumentModel.ListOf<Int32>? GetStep(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStep(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<Int32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Function
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.FunctionKind? GetFunction(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DocumentModel.Drawings.Diagrams.FunctionKind>(openXmlElement?.Function?.Value);
  }
  
  public static void SetFunction(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.FunctionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Function = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DocumentModel.Drawings.Diagrams.FunctionKind>(value);
  }
  
  /// <summary>
  /// Argument
  /// </summary>
  public static String? GetArgument(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetArgument(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.FunctionOperatorKind? GetOperator(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DocumentModel.Drawings.Diagrams.FunctionOperatorKind>(openXmlElement?.Operator?.Value);
  }
  
  public static void SetOperator(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.FunctionOperatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Operator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DocumentModel.Drawings.Diagrams.FunctionOperatorKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.Algorithm? GetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.Algorithm? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.Shape? GetShape(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.Shape? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.PresentationOf? GetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.PresentationOf? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.Constraints? GetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.Constraints? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.RuleList? GetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.RuleList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.ForEach? GetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.ForEach? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutNode? GetLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.LayoutNode? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.Choose? GetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.Choose? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
