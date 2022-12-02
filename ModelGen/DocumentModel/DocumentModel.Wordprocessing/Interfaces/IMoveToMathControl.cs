namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public interface IMoveToMathControl // : DocumentModel.Wordprocessing.IMathControlMoveType
{
  public IRunProperties? RunProperties { get ; set; }
  
  public IInsertedMathControl? InsertedMathControl { get ; set; }
  
  public IDeletedMathControl? DeletedMathControl { get ; set; }
  
}
