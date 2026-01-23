namespace DocumentModel.Drawings;

/// <summary>
///   Represents a QuickTime video sourced from a file, including a reference to the linked relationship.
/// </summary>
public class QuickTimeFromFile : ModelElement<DXD.QuickTimeFromFile>, IExtendableElement
{
  /// <summary>
  ///   Relationship ID that links to the QuickTime video file.
  /// </summary>
  public string? Link { get; set; }

  /// <summary>
  /// List of extension elements.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}