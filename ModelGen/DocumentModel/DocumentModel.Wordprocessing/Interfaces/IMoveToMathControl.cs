namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public interface IMoveToMathControl // : DocumentModel.Wordprocessing.IMathControlMoveType
{
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.IInsertedMathControl? InsertedMathControl { get ; set; }
  
  public DocumentModel.Wordprocessing.IDeletedMathControl? DeletedMathControl { get ; set; }
  
}
