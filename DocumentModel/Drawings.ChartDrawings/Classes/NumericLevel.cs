namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumericLevel Class.
/// </summary>
public class NumericLevel: ModelElement
{
  /// <summary>
  ///   ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? PtCount { get; set; }

  /// <summary>
  ///   formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   name, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Name { get; set; }

  public Collection<NumericValue>? NumericValues { get; set; }
}