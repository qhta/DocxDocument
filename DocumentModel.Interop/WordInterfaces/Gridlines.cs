namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents major or minor gridlines on a chart axis.
/// </summary>
public partial interface Gridlines : InteropObject
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
