namespace DocumentModel.Drawings;

/// <summary>
///   Represents a QuickTime video sourced from a file, including a reference to the linked relationship.
/// </summary>
public interface QuickTimeFromFile : IExtendableElement
{
  /// <summary>
  ///   Relationship ID that links to the QuickTime video file.
  /// </summary>
  public string? Link { get; set; }
}