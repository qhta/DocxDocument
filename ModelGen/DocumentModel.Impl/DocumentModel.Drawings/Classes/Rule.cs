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
  
  public RuleImpl(): base() {}
  
  public RuleImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Rule openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Constraint Type
  /// </summary>
  public DocumentModel.Drawings.ConstraintKind? Type
  {
    get => (DocumentModel.Drawings.ConstraintKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues?)value;
    }
  }
  
  /// <summary>
  /// For
  /// </summary>
  public DocumentModel.Drawings.ConstraintRelationshipKind? For
  {
    get => (DocumentModel.Drawings.ConstraintRelationshipKind?)OpenXmlElement?.For?.Value;
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
    get => (System.String?)OpenXmlElement?.ForName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ForName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.Drawings.ElementKind? PointType
  {
    get => (DocumentModel.Drawings.ElementKind?)OpenXmlElement?.PointType?.Value;
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
    get => (System.Double?)OpenXmlElement?.Val?.Value;
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
    get => (System.Double?)OpenXmlElement?.Fact?.Value;
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
    get => (System.Double?)OpenXmlElement?.Max?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Max = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
