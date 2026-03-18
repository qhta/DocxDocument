namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Parameter.
/// </summary>
public class Parameter : CollectionItem
{
  /// <summary>
  ///   Parameter Type
  /// </summary>
  public ParameterId? Type { get; set; }
  /// <summary>
  ///   Value
  /// </summary>
  public string? Val { get; set; }
}