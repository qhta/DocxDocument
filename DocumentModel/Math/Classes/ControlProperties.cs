using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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