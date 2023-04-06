namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public class MoveToMathControl: ModelElement
{
  public RunProperties? RunProperties { get; set; }

  public InsertedMathControl? InsertedMathControl { get; set; }

  public DeletedMathControl? DeletedMathControl { get; set; }
}