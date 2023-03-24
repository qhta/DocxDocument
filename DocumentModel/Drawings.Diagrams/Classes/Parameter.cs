namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Parameter.
/// </summary>
public class Parameter: ModelElement
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