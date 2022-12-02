namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveFromMathControl Class.
/// </summary>
public interface IMoveFromMathControl // : DocumentModel.Wordprocessing.IMathControlMoveType
{
  public IRunProperties? RunProperties { get ; set; }
  
  public IInsertedMathControl? InsertedMathControl { get ; set; }
  
  public IDeletedMathControl? DeletedMathControl { get ; set; }
  
}
