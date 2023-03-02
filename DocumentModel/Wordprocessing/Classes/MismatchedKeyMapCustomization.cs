namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public record MismatchedKeyMapCustomization
{
  public Collection<KeyMapEntry>? KeyMapEntries { get; set; }
}