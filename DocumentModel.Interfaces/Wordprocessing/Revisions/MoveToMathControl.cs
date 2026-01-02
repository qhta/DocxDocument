namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public class MoveToMathControl: ModelElement
{
  public RunProperties? RunProperties { get; set; }
  public InsertedMathControl? InsertedMathControl { get; set; }
  public DeletedMathControl? DeletedMathControl { get; set; }
}