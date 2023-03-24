namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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