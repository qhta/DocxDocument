namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public record ExtensionList
{
  public Collection<Extension>? Extensions { get; set; }
}