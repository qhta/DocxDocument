namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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