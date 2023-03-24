namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Phantom Properties.
/// </summary>
public class PhantomProperties: ModelElement
{
  /// <summary>
  ///   Phantom Show.
  /// </summary>
  public BooleanKind? ShowPhantom { get; set; }

  /// <summary>
  ///   Phantom Zero Width.
  /// </summary>
  public BooleanKind? ZeroWidth { get; set; }

  /// <summary>
  ///   Phantom Zero Ascent.
  /// </summary>
  public BooleanKind? ZeroAscent { get; set; }

  /// <summary>
  ///   Phantom Zero Descent.
  /// </summary>
  public BooleanKind? ZeroDescent { get; set; }

  /// <summary>
  ///   Transparent (Phantom).
  /// </summary>
  public BooleanKind? Transparent { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}