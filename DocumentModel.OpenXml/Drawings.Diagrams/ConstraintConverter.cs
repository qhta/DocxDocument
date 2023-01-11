namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Constraint.
/// </summary>
public static class ConstraintConverter
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ConstraintKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(value);
  }
  
  /// <summary>
  /// For
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? GetFor(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }
  
  public static void SetFor(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.For = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// For Name
  /// </summary>
  public static String? GetForName(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return openXmlElement?.ForName?.Value;
  }
  
  public static void SetForName(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForName = new StringValue { Value = value };
      else
        openXmlElement.ForName = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ElementKind? GetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(openXmlElement?.PointType?.Value);
  }
  
  public static void SetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.ElementKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(value);
  }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ConstraintKind? GetReferenceType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(openXmlElement?.ReferenceType?.Value);
  }
  
  public static void SetReferenceType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ReferenceType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(value);
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? GetReferenceFor(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(openXmlElement?.ReferenceFor?.Value);
  }
  
  public static void SetReferenceFor(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ReferenceFor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  public static String? GetReferenceForName(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return openXmlElement?.ReferenceForName?.Value;
  }
  
  public static void SetReferenceForName(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ReferenceForName = new StringValue { Value = value };
      else
        openXmlElement.ReferenceForName = null;
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ElementKind? GetReferencePointType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(openXmlElement?.ReferencePointType?.Value);
  }
  
  public static void SetReferencePointType(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.ElementKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ReferencePointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(value);
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.BoolOperatorKind? GetOperator(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DocumentModel.Drawings.Diagrams.BoolOperatorKind>(openXmlElement?.Operator?.Value);
  }
  
  public static void SetOperator(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.BoolOperatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Operator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DocumentModel.Drawings.Diagrams.BoolOperatorKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public static Double? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  public static Double? GetFact(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    return openXmlElement?.Fact?.Value;
  }
  
  public static void SetFact(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Fact = value;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
