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
  
  public Collection<DiagramChooseIf>? DiagramChooseIfs { get ; set; }
  
  public DiagramChooseElse? DiagramChooseElse { get ; set; }
  
}
