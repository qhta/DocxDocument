namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Description.
/// </summary>
public interface Description:
{
  /// <summary>
  ///   Language
  /// </summary>
  public string? Language { get; set; }
  /// <summary>
  ///   Value
  /// </summary>
  public string? Val { get; set; }
}