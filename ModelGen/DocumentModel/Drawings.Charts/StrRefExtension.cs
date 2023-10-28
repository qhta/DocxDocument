namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StrRefExtension Class.
/// </summary>
public partial class StrRefExtension
{
  
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DMDC13.FullReference? FullReference { get; set; }
  
  public DMDC13.LevelReference? LevelReference { get; set; }
  
  public DMDC13.FormulaReference? FormulaReference { get; set; }
  
}
