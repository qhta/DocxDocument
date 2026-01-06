namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Style Label Description.
/// </summary>
public interface StyleLabelDescription
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