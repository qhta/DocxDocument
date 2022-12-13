namespace DocumentModel.Drawings;

/// <summary>
/// For Each.
/// </summary>
public class ForEachImpl: ModelElementImpl, ForEach
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ForEach? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ForEach?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ForEachImpl(): base() {}
  
  public ForEachImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference
  {
    get => (System.String?)OpenXmlElement?.Reference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Reference = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<DocumentModel.Drawings.AxisKind>? Axis
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<DocumentModel.Drawings.ElementKind>? PointType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<System.Boolean>? HideLastTrans
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<System.Int32>? Start
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<System.UInt32>? Count
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<System.Int32>? Step
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Algorithm? Algorithm
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.PresentationOf? PresentationOf
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Constraints? Constraints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.RuleList? RuleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ForEach? ChildForEach
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.LayoutNode? LayoutNode
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Choose? Choose
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
