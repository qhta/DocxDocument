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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetForName(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  public static Double? GetFact(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFact(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public static Double? GetMax(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMax(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Rule? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
