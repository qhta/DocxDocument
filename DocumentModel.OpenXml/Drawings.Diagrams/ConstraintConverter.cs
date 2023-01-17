namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Constraint.
/// </summary>
public static class ConstraintConverter
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ConstraintKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(value);
  }
  
  /// <summary>
  /// For
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? GetFor(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }
  
  private static void SetFor(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? value)
  {
    openXmlElement.For = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// For Name
  /// </summary>
  private static String? GetForName(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return openXmlElement?.ForName?.Value;
  }
  
  private static void SetForName(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ForName = new StringValue { Value = value };
    else
      openXmlElement.ForName = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ElementKind? GetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(openXmlElement?.PointType?.Value);
  }
  
  private static void SetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, DocumentModel.Drawings.Diagrams.ElementKind? value)
  {
    openXmlElement.PointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(value);
  }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ConstraintKind? GetReferenceType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(openXmlElement?.ReferenceType?.Value);
  }
  
  private static void SetReferenceType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintKind? value)
  {
    openXmlElement.ReferenceType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(value);
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? GetReferenceFor(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(openXmlElement?.ReferenceFor?.Value);
  }
  
  private static void SetReferenceFor(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? value)
  {
    openXmlElement.ReferenceFor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  private static String? GetReferenceForName(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return openXmlElement?.ReferenceForName?.Value;
  }
  
  private static void SetReferenceForName(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ReferenceForName = new StringValue { Value = value };
    else
      openXmlElement.ReferenceForName = null;
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ElementKind? GetReferencePointType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(openXmlElement?.ReferencePointType?.Value);
  }
  
  private static void SetReferencePointType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, DocumentModel.Drawings.Diagrams.ElementKind? value)
  {
    openXmlElement.ReferencePointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(value);
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.BoolOperatorKind? GetOperator(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DocumentModel.Drawings.Diagrams.BoolOperatorKind>(openXmlElement?.Operator?.Value);
  }
  
  private static void SetOperator(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, DocumentModel.Drawings.Diagrams.BoolOperatorKind? value)
  {
    openXmlElement.Operator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DocumentModel.Drawings.Diagrams.BoolOperatorKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static Double? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, Double? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  private static Double? GetFact(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    return openXmlElement.Fact?.Value;
  }
  
  private static void SetFact(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, Double? value)
  {
    openXmlElement.Fact = value;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Constraint? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Constraint();
      value.Type = GetType(openXmlElement);
      value.For = GetFor(openXmlElement);
      value.ForName = GetForName(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.ReferenceType = GetReferenceType(openXmlElement);
      value.ReferenceFor = GetReferenceFor(openXmlElement);
      value.ReferenceForName = GetReferenceForName(openXmlElement);
      value.ReferencePointType = GetReferencePointType(openXmlElement);
      value.Operator = GetOperator(openXmlElement);
      value.Val = GetVal(openXmlElement);
      value.Fact = GetFact(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Constraint? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Constraint, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetFor(openXmlElement, value?.For);
      SetForName(openXmlElement, value?.ForName);
      SetPointType(openXmlElement, value?.PointType);
      SetReferenceType(openXmlElement, value?.ReferenceType);
      SetReferenceFor(openXmlElement, value?.ReferenceFor);
      SetReferenceForName(openXmlElement, value?.ReferenceForName);
      SetReferencePointType(openXmlElement, value?.ReferencePointType);
      SetOperator(openXmlElement, value?.Operator);
      SetVal(openXmlElement, value?.Val);
      SetFact(openXmlElement, value?.Fact);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
