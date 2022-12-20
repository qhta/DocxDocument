namespace DocumentModel.Drawings;

/// <summary>
/// QuickTime from File.
/// </summary>
public partial interface QuickTimeFromFile
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
