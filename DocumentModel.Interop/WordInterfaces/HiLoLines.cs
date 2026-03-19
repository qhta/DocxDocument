namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the high-low lines in a chart group.
/// </summary>
public partial interface HiLoLines : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
