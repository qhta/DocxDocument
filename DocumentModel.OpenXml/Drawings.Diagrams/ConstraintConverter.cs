using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Constraint = DocumentFormat.OpenXml.Drawing.Diagrams.Constraint;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Constraint.
/// </summary>
public static class ConstraintConverter
{
  /// <summary>
  ///   Constraint Type
  /// </summary>
  public static ConstraintKind? GetType(Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConstraintValues, ConstraintKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Constraint? openXmlElement, ConstraintKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<ConstraintValues, ConstraintKind>(value);
  }

  /// <summary>
  ///   For
  /// </summary>
  public static ConstraintRelationshipKind? GetFor(Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConstraintRelationshipValues, ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }

  public static void SetFor(Constraint? openXmlElement, ConstraintRelationshipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.For = EnumValueConverter.CreateEnumValue<ConstraintRelationshipValues, ConstraintRelationshipKind>(value);
  }

  /// <summary>
  ///   For Name
  /// </summary>
  public static String? GetForName(Constraint? openXmlElement)
  {
    return openXmlElement?.ForName?.Value;
  }

  public static void SetForName(Constraint? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForName = new StringValue { Value = value };
      else
        openXmlElement.ForName = null;
  }

  /// <summary>
  ///   Data Point Type
  /// </summary>
  public static ElementKind? GetPointType(Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<ElementValues, ElementKind>(openXmlElement?.PointType?.Value);
  }

  public static void SetPointType(Constraint? openXmlElement, ElementKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PointType = EnumValueConverter.CreateEnumValue<ElementValues, ElementKind>(value);
  }

  /// <summary>
  ///   Reference Type
  /// </summary>
  public static ConstraintKind? GetReferenceType(Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConstraintValues, ConstraintKind>(openXmlElement?.ReferenceType?.Value);
  }

  public static void SetReferenceType(Constraint? openXmlElement, ConstraintKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ReferenceType = EnumValueConverter.CreateEnumValue<ConstraintValues, ConstraintKind>(value);
  }

  /// <summary>
  ///   Reference For
  /// </summary>
  public static ConstraintRelationshipKind? GetReferenceFor(Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConstraintRelationshipValues, ConstraintRelationshipKind>(openXmlElement?.ReferenceFor?.Value);
  }

  public static void SetReferenceFor(Constraint? openXmlElement, ConstraintRelationshipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ReferenceFor = EnumValueConverter.CreateEnumValue<ConstraintRelationshipValues, ConstraintRelationshipKind>(value);
  }

  /// <summary>
  ///   Reference For Name
  /// </summary>
  public static String? GetReferenceForName(Constraint? openXmlElement)
  {
    return openXmlElement?.ReferenceForName?.Value;
  }

  public static void SetReferenceForName(Constraint? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ReferenceForName = new StringValue { Value = value };
      else
        openXmlElement.ReferenceForName = null;
  }

  /// <summary>
  ///   Reference Point Type
  /// </summary>
  public static ElementKind? GetReferencePointType(Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<ElementValues, ElementKind>(openXmlElement?.ReferencePointType?.Value);
  }

  public static void SetReferencePointType(Constraint? openXmlElement, ElementKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ReferencePointType = EnumValueConverter.CreateEnumValue<ElementValues, ElementKind>(value);
  }

  /// <summary>
  ///   Operator
  /// </summary>
  public static BoolOperatorKind? GetOperator(Constraint? openXmlElement)
  {
    return EnumValueConverter.GetValue<BoolOperatorValues, BoolOperatorKind>(openXmlElement?.Operator?.Value);
  }

  public static void SetOperator(Constraint? openXmlElement, BoolOperatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Operator = EnumValueConverter.CreateEnumValue<BoolOperatorValues, BoolOperatorKind>(value);
  }

  /// <summary>
  ///   Value
  /// </summary>
  public static Double? GetVal(Constraint? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(Constraint? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }

  /// <summary>
  ///   Factor
  /// </summary>
  public static Double? GetFact(Constraint? openXmlElement)
  {
    return openXmlElement?.Fact?.Value;
  }

  public static void SetFact(Constraint? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Fact = value;
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(Constraint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Constraint? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.Constraint? CreateModelElement(Constraint? openXmlElement)
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
    where OpenXmlElementType : Constraint, new()
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