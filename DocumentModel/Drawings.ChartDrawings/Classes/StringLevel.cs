namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StringLevel Class.
/// </summary>
public class StringLevel: ModelElement
{
  /// <summary>
  ///   ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? PtCount { get; set; }

  /// <summary>
  ///   name, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Name { get; set; }

  public Collection<ChartStringValue>? ChartStringValues { get; set; }
}