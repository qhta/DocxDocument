namespace DocumentModel.Drawings;

/// <summary>
///   Build Diagram.
/// </summary>
public class BuildDiagram: ModelElement
{
  /// <summary>
  ///   Build
  /// </summary>
  public String? Build { get; set; }

  /// <summary>
  ///   Reverse Animation
  /// </summary>
  public Boolean? ReverseAnimation { get; set; }
}