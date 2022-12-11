namespace DocumentModel.Drawings;

/// <summary>
/// Audio from File.
/// </summary>
public interface AudioFromFile
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public String? Link { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
