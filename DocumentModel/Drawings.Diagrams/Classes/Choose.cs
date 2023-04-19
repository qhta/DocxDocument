namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Choose Element.
/// </summary>
public class Choose: ModelElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }

  public DiagramChooseIf? DiagramChooseIf { get; set; }

  public DiagramChooseElse? DiagramChooseElse { get; set; }
}