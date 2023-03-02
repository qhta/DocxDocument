namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ExtraColorSchemeList Class.
/// </summary>
public record ExtraColorSchemeList
{
  public Collection<ExtraColorScheme>? ExtraColorSchemes { get; set; }
}