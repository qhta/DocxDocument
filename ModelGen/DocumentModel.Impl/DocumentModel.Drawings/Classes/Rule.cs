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
    get => (String?)OpenXmlElement?.ForName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ForName = (System.String?)value;
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
  /// Value
  /// </summary>
  public Double? Val
  {
    get => (Double?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  public Double? Fact
  {
    get => (Double?)OpenXmlElement?.Fact?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Fact = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public Double? Max
  {
    get => (Double?)OpenXmlElement?.Max?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Max = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
