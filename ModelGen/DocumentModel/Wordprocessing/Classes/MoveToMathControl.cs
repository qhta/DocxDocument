namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public partial class MoveToMathControl
{
  public RunProperties? RunProperties { get; set; }
  
  public InsertedMathControl? InsertedMathControl { get; set; }
  
  public DeletedMathControl? DeletedMathControl { get; set; }
  
}
