namespace DocumentModel.Drawings;

/// <summary>
/// Constraint.
/// </summary>
public class ConstraintImpl: ModelElementImpl, Constraint
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Constraint?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConstraintImpl(): base() {}
  
  public ConstraintImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement): base(openXmlElement)
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
  /// Reference Type
  /// </summary>
  public DocumentModel.Drawings.ConstraintKind? ReferenceType
  {
    get => (DocumentModel.Drawings.ConstraintKind?)OpenXmlElement?.ReferenceType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferenceType = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues?)value;
    }
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public DocumentModel.Drawings.ConstraintRelationshipKind? ReferenceFor
  {
    get => (DocumentModel.Drawings.ConstraintRelationshipKind?)OpenXmlElement?.ReferenceFor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferenceFor = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues?)value;
    }
  }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  public String? ReferenceForName
  {
    get => (System.String?)OpenXmlElement?.ReferenceForName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferenceForName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public DocumentModel.Drawings.ElementKind? ReferencePointType
  {
    get => (DocumentModel.Drawings.ElementKind?)OpenXmlElement?.ReferencePointType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferencePointType = (DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues?)value;
    }
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public DocumentModel.Drawings.BoolOperatorKind? Operator
  {
    get => (DocumentModel.Drawings.BoolOperatorKind?)OpenXmlElement?.Operator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Operator = (DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues?)value;
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
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
