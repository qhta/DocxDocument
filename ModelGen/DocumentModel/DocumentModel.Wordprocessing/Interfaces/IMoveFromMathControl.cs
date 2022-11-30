namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveFromMathControl Class.
/// </summary>
public interface IMoveFromMathControl // : DocumentModel.Wordprocessing.IMathControlMoveType
{
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.IInsertedMathControl? InsertedMathControl { get ; set; }
  
  public DocumentModel.Wordprocessing.IDeletedMathControl? DeletedMathControl { get ; set; }
  
}
