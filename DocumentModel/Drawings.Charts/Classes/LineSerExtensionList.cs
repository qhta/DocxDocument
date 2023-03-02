namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineSerExtensionList Class.
/// </summary>
public record LineSerExtensionList
{
  public Collection<LineSerExtension>? LineSerExtensions { get; set; }
}