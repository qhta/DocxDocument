namespace DocumentModel.Drawings;

/// <summary>
/// Choose Element.
/// </summary>
public interface Choose
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  public DocumentModel.Drawings.DiagramChooseIf? DiagramChooseIf { get ; set; }
  
  public DocumentModel.Drawings.DiagramChooseElse? DiagramChooseElse { get ; set; }
  
}
