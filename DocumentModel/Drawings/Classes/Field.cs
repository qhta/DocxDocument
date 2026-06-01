namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Text IField.
/// </summary>
public class IField: ModelElement
{
  /// <summary>
  ///   IField ID
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   IField Type
  /// </summary>
  public string? Type { get; set; }

  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }

  /// <summary>
  ///   Text IParagraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }

  /// <summary>
  ///   Text.
  /// </summary>
  public string? Text { get; set; }
}
