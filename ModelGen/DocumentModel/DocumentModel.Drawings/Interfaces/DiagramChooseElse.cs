namespace DocumentModel.Drawings;

/// <summary>
/// Else.
/// </summary>
public interface DiagramChooseElse
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  public DocumentModel.Drawings.Algorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawings.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.PresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawings.Constraints? Constraints { get ; set; }
  
  public DocumentModel.Drawings.RuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawings.ForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawings.LayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawings.Choose? Choose { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
