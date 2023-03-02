namespace DocumentModel.Drawings;

/// <summary>
///   Miter Line Join.
/// </summary>
public record Miter
{
  /// <summary>
  ///   Miter Join Limit
  /// </summary>
  public Int32? Limit { get; set; }
}