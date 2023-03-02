namespace DocumentModel.UI;

/// <summary>
///   Defines CustomUI.
/// </summary>
public record CustomUI
{
  /// <summary>
  ///   onLoad
  /// </summary>
  public String? OnLoad { get; set; }

  /// <summary>
  ///   loadImage
  /// </summary>
  public String? LoadImage { get; set; }

  /// <summary>
  ///   RepurposedCommands.
  /// </summary>
  public RepurposedCommands? RepurposedCommands { get; set; }

  /// <summary>
  ///   Ribbon.
  /// </summary>
  public Ribbon? Ribbon { get; set; }
}