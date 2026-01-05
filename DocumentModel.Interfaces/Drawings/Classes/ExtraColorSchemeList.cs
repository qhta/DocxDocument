namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ExtraColorSchemeList interface.
/// </summary>
public interface ExtraColorSchemeList:
{
  public Collection<ExtraColorScheme>? ExtraColorSchemes { get; set; }
}