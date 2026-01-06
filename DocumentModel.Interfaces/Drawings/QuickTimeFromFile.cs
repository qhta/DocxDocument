namespace DocumentModel.Drawings;

/// <summary>
///   QuickTime from File.
/// </summary>
public interface QuickTimeFromFile: ExtendableElement
{
  /// <summary>
  ///   Linked Relationship ID
  /// </summary>
  public string? Link { get; set; }

}