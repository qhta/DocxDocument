namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the NumberFormat Class.
/// </summary>
public interface NumberFormat: IModelElement
{
  /// <summary>
  ///   formatCode
  /// </summary>
  public string? FormatCode { get; set; }
  /// <summary>
  ///   sourceLinked
  /// </summary>
  public bool? SourceLinked { get; set; }
}