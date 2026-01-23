namespace DocumentModel.Drawings;

/// <summary>
///   Represents a video sourced from a file, including a reference to the linked relationship.
/// </summary>
public class VideoFromFile : ModelElement<DXD.VideoFromFile>, IExtendableElement
{
  /// <summary>
  ///   Relationship ID that links to the video file.
  /// </summary>
  public string? Link { get; set; }

  /// <summary>
  /// List of extension elements.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}