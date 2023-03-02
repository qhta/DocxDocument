namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Parameter.
/// </summary>
public record Parameter
{
  /// <summary>
  ///   Parameter Type
  /// </summary>
  public ParameterIdKind? Type { get; set; }

  /// <summary>
  ///   Value
  /// </summary>
  public String? Val { get; set; }
}