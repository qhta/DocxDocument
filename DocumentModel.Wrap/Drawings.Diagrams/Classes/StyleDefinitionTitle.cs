namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Title.
/// </summary>
public class StyleDefinitionTitle: ModelElement
{
  /// <summary>
  ///   Natural Language
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   Description Value
  /// </summary>
  public string? Val { get; set; }
}