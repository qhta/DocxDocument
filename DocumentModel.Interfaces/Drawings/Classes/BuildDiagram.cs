namespace DocumentModel.Drawings;

/// <summary>
///   Build Diagram.
/// </summary>
public interface BuildDiagram
{
  /// <summary>
  ///   Build
  /// </summary>
  public string? Build { get; set; }
  /// <summary>
  ///   Reverse Animation
  /// </summary>
  public bool? ReverseAnimation { get; set; }
}