namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StringReference Class.
/// </summary>
public partial class StringReference
{
  
  /// <summary>
  ///   Formula.
  /// </summary>
  public DocumentModel.Drawings.Charts.Formula? Formula { get; set; }
  
  
  /// <summary>
  ///   StringCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringCache? StringCache { get; set; }
  
  
  /// <summary>
  ///   StrRefExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.StrRefExtensionList? StrRefExtensionList { get; set; }
  
}
