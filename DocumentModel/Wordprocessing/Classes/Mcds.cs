namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Mcds Class.
/// </summary>
public record Mcds
{
  public Collection<Mcd>? Items { get; set; }
}