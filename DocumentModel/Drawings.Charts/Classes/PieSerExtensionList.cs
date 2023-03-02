namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PieSerExtensionList Class.
/// </summary>
public record PieSerExtensionList
{
  public Collection<PieSerExtension>? PieSerExtensions { get; set; }
}