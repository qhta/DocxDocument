namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the StyleReference Class.
/// </summary>
public interface StyleReference
{
  /// <summary>
  ///   idx
  /// </summary>
  public UInt32? Index { get; set; }
  /// <summary>
  ///   mods
  /// </summary>
  public ListOf<String>? Modifiers { get; set; }
}