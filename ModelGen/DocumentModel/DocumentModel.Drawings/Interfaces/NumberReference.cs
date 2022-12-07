namespace DocumentModel.Drawings;

/// <summary>
/// Number Reference.
/// </summary>
public interface NumberReference
{
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public NumberingCache? NumberingCache { get ; set; }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public NumRefExtensionList? NumRefExtensionList { get ; set; }
  
}
