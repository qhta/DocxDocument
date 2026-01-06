namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Parameter.
/// </summary>
public interface Parameter
{
  /// <summary>
  ///   Parameter Type
  /// </summary>
  public ParameterIdKind? Type { get; set; }
  /// <summary>
  ///   Value
  /// </summary>
  public string? Val { get; set; }
}