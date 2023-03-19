namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Choose Element.
/// </summary>
public class Choose: ModelElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }

  public DiagramChooseIf? DiagramChooseIf { get; set; }

  public DiagramChooseElse? DiagramChooseElse { get; set; }
}