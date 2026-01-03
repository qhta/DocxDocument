namespace DocumentModel.Drawings;

/// <summary>
///   Audio from File.
/// </summary>
public interface AudioFromFile: IModelElement
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