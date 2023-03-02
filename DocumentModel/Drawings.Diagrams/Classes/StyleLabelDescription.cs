namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Style Label Description.
/// </summary>
public record StyleLabelDescription
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