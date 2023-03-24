namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Run Properties.
/// </summary>
public class RunProperties: ModelElement
{
  /// <summary>
  ///   Literal.
  /// </summary>
  public BooleanKind? Literal { get; set; }

  public BooleanKind? NormalText { get; set; }

  public ScriptKind? Script { get; set; }

  public StyleKind? Style { get; set; }

  public Break? Break { get; set; }

  public BooleanKind? Alignment { get; set; }
}