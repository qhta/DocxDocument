namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Choose Element.
/// </summary>
public interface Choose: IModelElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
  public DiagramChooseIf? DiagramChooseIf { get; set; }
  public DiagramChooseElse? DiagramChooseElse { get; set; }
}