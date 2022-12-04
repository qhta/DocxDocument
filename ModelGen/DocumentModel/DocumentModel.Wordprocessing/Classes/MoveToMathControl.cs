namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public class MoveToMathControl: DocumentModel.Wordprocessing.MathControlMoveType
{
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
  public InsertedMathControl? InsertedMathControl
  {
    get;
    set;
  }
  
  public DeletedMathControl? DeletedMathControl
  {
    get;
    set;
  }
  
}
