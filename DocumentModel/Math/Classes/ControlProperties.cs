using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   Control Properties.
/// </summary>
public class ControlProperties: ModelElement
{
  public Wordprocessing.RunProperties? RunProperties { get; set; }

  public InsertedMathControl? InsertedMathControl { get; set; }

  public DeletedMathControl? DeletedMathControl { get; set; }

  public MoveFromMathControl? MoveFromMathControl { get; set; }

  public MoveToMathControl? MoveToMathControl { get; set; }

}