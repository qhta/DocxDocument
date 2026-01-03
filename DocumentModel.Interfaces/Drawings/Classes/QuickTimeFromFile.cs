namespace DocumentModel.Drawings;

/// <summary>
///   QuickTime from File.
/// </summary>
public interface QuickTimeFromFile: IModelElement
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