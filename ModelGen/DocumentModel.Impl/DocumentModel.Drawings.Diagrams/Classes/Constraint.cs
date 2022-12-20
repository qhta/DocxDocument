namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Constraint.
/// </summary>
public partial class ConstraintImpl: ModelElementImpl, Constraint
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.Constraint? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Constraint?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ConstraintImpl(): base() {}
  
  public ConstraintImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Constraint Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ConstraintKind? Type
  {
    get => (DocumentModel.Drawings.Diagrams.ConstraintKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues?)value;
    }
  }
  
  /// <summary>
  /// For
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? For
  {
    get => (DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind?)OpenXmlElement?.For?.Value;
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
  public DocumentModel.Drawings.Diagrams.ElementKind? PointType
  {
    get => (DocumentModel.Drawings.Diagrams.ElementKind?)OpenXmlElement?.PointType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PointType = (DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues?)value;
    }
  }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ConstraintKind? ReferenceType
  {
    get => (DocumentModel.Drawings.Diagrams.ConstraintKind?)OpenXmlElement?.ReferenceType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferenceType = (DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues?)value;
    }
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? ReferenceFor
  {
    get => (DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind?)OpenXmlElement?.ReferenceFor?.Value;
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
  public DocumentModel.Drawings.Diagrams.ElementKind? ReferencePointType
  {
    get => (DocumentModel.Drawings.Diagrams.ElementKind?)OpenXmlElement?.ReferencePointType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReferencePointType = (DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues?)value;
    }
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public DocumentModel.Drawings.Diagrams.BoolOperatorKind? Operator
  {
    get => (DocumentModel.Drawings.Diagrams.BoolOperatorKind?)OpenXmlElement?.Operator?.Value;
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
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
