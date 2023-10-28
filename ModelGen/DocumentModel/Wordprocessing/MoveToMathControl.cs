namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public partial class MoveToMathControl
{
  public DMW.RunProperties? RunProperties { get; set; }
  
  public DMW.InsertedMathControl? InsertedMathControl { get; set; }
  
  public DMW.DeletedMathControl? DeletedMathControl { get; set; }
  
}
