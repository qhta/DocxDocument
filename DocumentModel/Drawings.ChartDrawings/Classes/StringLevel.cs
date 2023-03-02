namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the StringLevel Class.
/// </summary>
public record StringLevel
{
  /// <summary>
  ///   ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? PtCount { get; set; }

  /// <summary>
  ///   name, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Name { get; set; }

  public Collection<ChartStringValue>? ChartStringValues { get; set; }
}