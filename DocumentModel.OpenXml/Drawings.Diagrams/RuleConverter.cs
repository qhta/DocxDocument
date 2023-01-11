namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ConstraintKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DocumentModel.Drawings.Diagrams.ConstraintKind>(value);
  }
  
  /// <summary>
  /// For
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? GetFor(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }
  
  public static void SetFor(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.For = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// For Name
  /// </summary>
  public static String? GetForName(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    return openXmlElement?.ForName?.Value;
  }
  
  public static void SetForName(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, String? value)
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
  public static DocumentModel.Drawings.Diagrams.ElementKind? GetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(openXmlElement?.PointType?.Value);
  }
  
  public static void SetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, DocumentModel.Drawings.Diagrams.ElementKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public static Double? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  public static Double? GetFact(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    return openXmlElement?.Fact?.Value;
  }
  
  public static void SetFact(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Fact = value;
  }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public static Double? GetMax(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    return openXmlElement?.Max?.Value;
  }
  
  public static void SetMax(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Max = value;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.Rule? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Rule, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
