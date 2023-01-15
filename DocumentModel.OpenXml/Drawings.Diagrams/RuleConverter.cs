using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Rule = DocumentFormat.OpenXml.Drawing.Diagrams.Rule;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  ///   Constraint Type
  /// </summary>
  public static ConstraintKind? GetType(Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConstraintValues, ConstraintKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Rule? openXmlElement, ConstraintKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<ConstraintValues, ConstraintKind>(value);
  }

  /// <summary>
  ///   For
  /// </summary>
  public static ConstraintRelationshipKind? GetFor(Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConstraintRelationshipValues, ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }

  public static void SetFor(Rule? openXmlElement, ConstraintRelationshipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.For = EnumValueConverter.CreateEnumValue<ConstraintRelationshipValues, ConstraintRelationshipKind>(value);
  }

  /// <summary>
  ///   For Name
  /// </summary>
  public static String? GetForName(Rule? openXmlElement)
  {
    return openXmlElement?.ForName?.Value;
  }

  public static void SetForName(Rule? openXmlElement, String? value)
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
  public static ElementKind? GetPointType(Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<ElementValues, ElementKind>(openXmlElement?.PointType?.Value);
  }

  public static void SetPointType(Rule? openXmlElement, ElementKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PointType = EnumValueConverter.CreateEnumValue<ElementValues, ElementKind>(value);
  }

  /// <summary>
  ///   Value
  /// </summary>
  public static Double? GetVal(Rule? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(Rule? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }

  /// <summary>
  ///   Factor
  /// </summary>
  public static Double? GetFact(Rule? openXmlElement)
  {
    return openXmlElement?.Fact?.Value;
  }

  public static void SetFact(Rule? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Fact = value;
  }

  /// <summary>
  ///   Max Value
  /// </summary>
  public static Double? GetMax(Rule? openXmlElement)
  {
    return openXmlElement?.Max?.Value;
  }

  public static void SetMax(Rule? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Max = value;
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(Rule? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Rule? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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

  public static DocumentModel.Drawings.Diagrams.Rule? CreateModelElement(Rule? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Rule();
      value.Type = GetType(openXmlElement);
      value.For = GetFor(openXmlElement);
      value.ForName = GetForName(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      value.Fact = GetFact(openXmlElement);
      value.Max = GetMax(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Rule? value)
    where OpenXmlElementType : Rule, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetFor(openXmlElement, value?.For);
      SetForName(openXmlElement, value?.ForName);
      SetPointType(openXmlElement, value?.PointType);
      SetVal(openXmlElement, value?.Val);
      SetFact(openXmlElement, value?.Fact);
      SetMax(openXmlElement, value?.Max);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}