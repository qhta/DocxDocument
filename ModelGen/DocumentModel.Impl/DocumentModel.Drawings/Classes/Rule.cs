namespace DocumentModel.Drawings;

/// <summary>
/// Rule.
/// </summary>
public class RuleImpl: ModelElementImpl, Rule
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Rule? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Rule?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// For Name
  /// </summary>
  public String? ForName
  {
    get;
    set;
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
  /// Value
  /// </summary>
  public Double? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  public Double? Fact
  {
    get;
    set;
  }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public Double? Max
  {
    get;
    set;
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
