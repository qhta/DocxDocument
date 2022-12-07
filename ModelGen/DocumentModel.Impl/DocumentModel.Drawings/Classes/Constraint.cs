namespace DocumentModel.Drawings;

/// <summary>
/// Constraint.
/// </summary>
public class ConstraintImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>, Constraint
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public ConstraintKind? Type
  {
    get => (ConstraintKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues?)value;
    }
  }
  
  /// <summary>
  /// For
  /// </summary>
  public ConstraintRelationshipKind? For
  {
    get => (ConstraintRelationshipKind?)OpenXmlElement?.For?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.For = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues?)value;
    }
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public ElementKind? PointType
  {
    get => (ElementKind?)OpenXmlElement?.PointType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PointType = (DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues?)value;
    }
  }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public ConstraintKind? ReferenceType
  {
    get => (ConstraintKind?)OpenXmlElement?.ReferenceType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferenceType = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues?)value;
    }
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public ConstraintRelationshipKind? ReferenceFor
  {
    get => (ConstraintRelationshipKind?)OpenXmlElement?.ReferenceFor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferenceFor = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues?)value;
    }
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public ElementKind? ReferencePointType
  {
    get => (ElementKind?)OpenXmlElement?.ReferencePointType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferencePointType = (DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues?)value;
    }
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public BoolOperatorKind? Operator
  {
    get => (BoolOperatorKind?)OpenXmlElement?.Operator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Operator = (DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
