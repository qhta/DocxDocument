namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the KeyMapCustomizations Class.
/// </summary>
public record KeyMapCustomizations
{
  public Collection<KeyMapEntry>? KeyMapEntries { get; set; }
}