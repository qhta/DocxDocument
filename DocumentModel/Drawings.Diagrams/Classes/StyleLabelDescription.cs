namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Style Label Description.
/// </summary>
public class StyleLabelDescription: ModelElement
{
  /// <summary>
  ///   Natural Language
  /// </summary>
  public String? Language { get; set; }

  /// <summary>
  ///   Description Value
  /// </summary>
  public String? Val { get; set; }
}