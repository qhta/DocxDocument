namespace DocumentModel.Drawings;

/// <summary>
/// Rule.
/// </summary>
public class RuleImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>, Rule
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
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
