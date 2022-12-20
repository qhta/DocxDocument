namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Else.
/// </summary>
public partial interface DiagramChooseElse
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Algorithm? Algorithm { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Shape? Shape { get; set; }
  
  public DocumentModel.Drawings.Diagrams.PresentationOf? PresentationOf { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Constraints? Constraints { get; set; }
  
  public DocumentModel.Drawings.Diagrams.RuleList? RuleList { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ForEach? ForEach { get; set; }
  
  public DocumentModel.Drawings.Diagrams.LayoutNode? LayoutNode { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Choose? Choose { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
