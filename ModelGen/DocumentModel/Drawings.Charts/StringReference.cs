namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StringReference Class.
/// </summary>
public partial class StringReference
{
  
  /// <summary>
  ///   Formula.
  /// </summary>
  public DMDC.Formula? Formula { get; set; }
  
  
  /// <summary>
  ///   StringCache.
  /// </summary>
  public DMDC.StringCache? StringCache { get; set; }
  
  
  /// <summary>
  ///   StrRefExtensionList.
  /// </summary>
  public DMDC.StrRefExtensionList? StrRefExtensionList { get; set; }
  
}
