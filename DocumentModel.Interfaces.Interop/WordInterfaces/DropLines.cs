namespace DocumentModel.Interop;

/// <summary>
/// Represents the drop lines in a chart group.
/// </summary>
public partial interface DropLines : InteropObject
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
