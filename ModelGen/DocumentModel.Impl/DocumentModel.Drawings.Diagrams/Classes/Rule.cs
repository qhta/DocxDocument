namespace DocumentModel.Drawings.Diagrams;

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
