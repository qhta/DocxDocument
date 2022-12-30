namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public partial class NumberReference
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get; set; }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingCache? NumberingCache { get; set; }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumRefExtensionList? NumRefExtensionList { get; set; }
  
}
