namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public interface MoveToMathControl
{
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.InsertedMathControl? InsertedMathControl { get ; set; }
  
  public DocumentModel.Wordprocessing.DeletedMathControl? DeletedMathControl { get ; set; }
  
}
