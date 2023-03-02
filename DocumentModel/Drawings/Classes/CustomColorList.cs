namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CustomColorList Class.
/// </summary>
public record CustomColorList
{
  public Collection<CustomColor>? CustomColors { get; set; }
}