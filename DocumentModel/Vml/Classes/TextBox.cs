using DocumentModel.Wordprocessing;

namespace DocumentModel.Vml;

/// <summary>
///   Defines the TextBox Class.
/// </summary>
public record TextBox
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public String? Style { get; set; }

  /// <summary>
  ///   Text Box Inset
  /// </summary>
  public String? Inset { get; set; }

  /// <summary>
  ///   Text Box Single-Click Selection Toggle
  /// </summary>
  public Boolean? SingleClick { get; set; }

  public TextBoxContent? TextBoxContent { get; set; }
}