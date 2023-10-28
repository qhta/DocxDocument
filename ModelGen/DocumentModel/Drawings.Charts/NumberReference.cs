namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Number Reference.
/// </summary>
public partial class NumberReference
{
  
  /// <summary>
  ///   Formula.
  /// </summary>
  public DMDC.Formula? Formula { get; set; }
  
  
  /// <summary>
  ///   NumberingCache.
  /// </summary>
  public DMDC.NumberingCache? NumberingCache { get; set; }
  
  
  /// <summary>
  ///   NumRefExtensionList.
  /// </summary>
  public DMDC.NumRefExtensionList? NumRefExtensionList { get; set; }
  
}
