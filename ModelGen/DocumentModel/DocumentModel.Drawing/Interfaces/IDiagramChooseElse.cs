namespace DocumentModel.Drawing;

/// <summary>
/// Else.
/// </summary>
public interface IDiagramChooseElse // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  public Collection<IAlgorithm>? Algorithms { get ; set; }
  
  public Collection<IShape>? Shapes { get ; set; }
  
  public Collection<IPresentationOf>? PresentationOfs { get ; set; }
  
  public Collection<IConstraints>? Constraintses { get ; set; }
  
  public Collection<IRuleList>? RuleLists { get ; set; }
  
  public Collection<IForEach>? ForEachs { get ; set; }
  
  public Collection<ILayoutNode>? LayoutNodes { get ; set; }
  
  public Collection<IChoose>? Chooses { get ; set; }
  
  public Collection<IExtensionList>? ExtensionLists { get ; set; }
  
}
