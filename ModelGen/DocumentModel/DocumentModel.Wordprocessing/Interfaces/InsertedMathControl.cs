namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the InsertedMathControl Class.
/// </summary>
public interface InsertedMathControl
{
  public RunProperties? RunProperties { get ; set; }
  
  public DeletedMathControl? DeletedMathControl { get ; set; }
  
}
