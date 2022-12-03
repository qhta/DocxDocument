namespace DocumentModel.Drawings;

/// <summary>
/// Number Reference.
/// </summary>
public interface NumberReference // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public NumberingCache? NumberingCache { get ; set; }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public NumRefExtensionList? NumRefExtensionList { get ; set; }
  
}
