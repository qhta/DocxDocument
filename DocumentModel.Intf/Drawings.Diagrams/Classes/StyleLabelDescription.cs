namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Style Label Description.
/// </summary>
public class StyleLabelDescription: ModelElement
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