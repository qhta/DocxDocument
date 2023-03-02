namespace DocumentModel.Drawings;

/// <summary>
///   Video from File.
/// </summary>
public record VideoFromFile
{
  /// <summary>
  ///   Linked Relationship ID
  /// </summary>
  public String? Link { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}