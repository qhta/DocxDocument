namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Choose Element.
/// </summary>
public partial class Choose
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get; set; }
  
  public DocumentModel.Drawings.Diagrams.DiagramChooseIf? DiagramChooseIf { get; set; }
  
  public DocumentModel.Drawings.Diagrams.DiagramChooseElse? DiagramChooseElse { get; set; }
  
}
