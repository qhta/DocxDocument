namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveFromMathControl Class.
/// </summary>
public partial class MoveFromMathControl
{
  public DMW.RunProperties? RunProperties { get; set; }
  
  public DMW.InsertedMathControl? InsertedMathControl { get; set; }
  
  public DMW.DeletedMathControl? DeletedMathControl { get; set; }
  
}
