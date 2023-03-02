namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumRefExtensionList Class.
/// </summary>
public record NumRefExtensionList
{
  public Collection<NumRefExtension>? NumRefExtensions { get; set; }
}