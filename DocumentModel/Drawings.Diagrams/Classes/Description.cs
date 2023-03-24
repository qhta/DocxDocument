namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Description.
/// </summary>
public class Description: ModelElement
{
  /// <summary>
  ///   Language
  /// </summary>
  public String? Language { get; set; }

  /// <summary>
  ///   Value
  /// </summary>
  public String? Val { get; set; }
}