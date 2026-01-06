namespace DocumentModel.Drawings;

/// <summary>
///   Video from File.
/// </summary>
public interface VideoFromFile: ExtendableElement
{
  /// <summary>
  ///   Linked Relationship ID
  /// </summary>
  public string? Link { get; set; }
}