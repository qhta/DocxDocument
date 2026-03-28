namespace DocumentModel.Interop;

/// <summary>
/// Represents a style used to build a table of contents or figures.
/// </summary>
public partial interface HeadingStyle : InteropObject
{
  /// <summary>
  /// The style.
  /// </summary>
  public object Style { get; set; }

  /// <summary>
  /// The level.
  /// </summary>
  public short Level { get; set; }
}
