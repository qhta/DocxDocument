namespace DocumentModel.Drawings;

/// <summary>
/// Video from File.
/// </summary>
public partial interface VideoFromFile
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public String? Link { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
