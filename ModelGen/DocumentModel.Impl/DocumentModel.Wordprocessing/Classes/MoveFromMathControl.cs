namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveFromMathControl Class.
/// </summary>
public class MoveFromMathControlImpl: DocumentModel.Wordprocessing.MathControlMoveTypeImpl, MoveFromMathControl
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
