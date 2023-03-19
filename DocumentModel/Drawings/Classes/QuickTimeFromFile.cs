namespace DocumentModel.Drawings;

/// <summary>
///   QuickTime from File.
/// </summary>
public class QuickTimeFromFile: ModelElement
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