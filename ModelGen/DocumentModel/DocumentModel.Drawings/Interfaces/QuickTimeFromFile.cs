namespace DocumentModel.Drawings;

/// <summary>
/// QuickTime from File.
/// </summary>
public interface QuickTimeFromFile
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public String? Link { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}
