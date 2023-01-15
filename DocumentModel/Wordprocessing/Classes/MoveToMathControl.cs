namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public class MoveToMathControl
{
  public RunProperties? RunProperties { get; set; }

  public InsertedMathControl? InsertedMathControl { get; set; }

  public DeletedMathControl? DeletedMathControl { get; set; }
}