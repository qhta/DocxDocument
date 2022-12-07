namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public interface StringReference
{
  /// <summary>
  /// StringCache.
  /// </summary>
  public StringCache? StringCache { get ; set; }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public StrRefExtensionList? StrRefExtensionList { get ; set; }
  
}
