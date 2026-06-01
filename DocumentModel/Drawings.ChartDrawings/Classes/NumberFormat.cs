namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the NumberFormat Class.
/// </summary>
public class NumberFormat: ModelElement
{
  /// <summary>
  ///   formatCode, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   sourceLinked, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public bool? SourceLinked { get; set; }
}
