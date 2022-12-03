namespace DocumentModel.Drawings;

/// <summary>
/// Else.
/// </summary>
public interface DiagramChooseElse // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  public Collection<Algorithm>? Algorithms { get ; set; }
  
  public Collection<Shape>? Shapes { get ; set; }
  
  public Collection<PresentationOf>? PresentationOfs { get ; set; }
  
  public Collection<Constraints>? Constraintses { get ; set; }
  
  public Collection<RuleList>? RuleLists { get ; set; }
  
  public Collection<ForEach>? ForEachs { get ; set; }
  
  public Collection<LayoutNode>? LayoutNodes { get ; set; }
  
  public Collection<Choose>? Chooses { get ; set; }
  
  public Collection<ExtensionList>? ExtensionLists { get ; set; }
  
}
