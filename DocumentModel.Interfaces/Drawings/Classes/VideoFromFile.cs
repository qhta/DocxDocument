namespace DocumentModel.Drawings;

/// <summary>
///   Video from File.
/// </summary>
public interface VideoFromFile: IModelElement
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