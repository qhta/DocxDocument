using DocumentModel.Wordprocessing;

namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TextBox Class.
/// </summary>
public class TextBox: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   IShape Styling Properties
  /// </summary>
  public string? IStyle { get; set; }

  /// <summary>
  ///   Text Box Inset
  /// </summary>
  public string? Inset { get; set; }

  /// <summary>
  ///   Text Box Single-Click ISelection Toggle
  /// </summary>
  public bool? SingleClick { get; set; }

  public TextBoxContent? TextBoxContent { get; set; }
}
