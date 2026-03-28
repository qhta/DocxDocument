namespace DocumentModel.Interop;

/// <summary>
/// Represents the mathematical n-ary object, consisting of an n-ary object, a base (or operand), and optional upper limits and lower limits.
/// </summary>
public interface OMathNary : InteropObject
{
  /// <summary>
  /// The sub.
  /// </summary>
  public OMath Sub { get; }
  /// <summary>
  /// The sup.
  /// </summary>
  public OMath Sup { get; }
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The char.
  /// </summary>
  public short Char { get; set; }
  /// <summary>
  /// The grow.
  /// </summary>
  public bool Grow { get; set; }
  /// <summary>
  /// The sub sup lim.
  /// </summary>
  public bool SubSupLim { get; set; }
  /// <summary>
  /// The hide sub.
  /// </summary>
  public bool HideSub { get; set; }
  /// <summary>
  /// The hide sup.
  /// </summary>
  public bool HideSup { get; set; }

}
