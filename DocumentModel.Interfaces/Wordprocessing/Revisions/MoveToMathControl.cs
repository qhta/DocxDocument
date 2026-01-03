namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public interface MoveToMathControl: IModelElement
{
  public RunProperties? RunProperties { get; set; }
  public InsertedMathControl? InsertedMathControl { get; set; }
  public DeletedMathControl? DeletedMathControl { get; set; }
}