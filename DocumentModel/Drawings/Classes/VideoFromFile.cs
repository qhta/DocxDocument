namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Video from File.
/// </summary>
public class VideoFromFile: ModelElement
{
  /// <summary>
  ///   Linked Relationship ID
  /// </summary>
  public string? Link { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}