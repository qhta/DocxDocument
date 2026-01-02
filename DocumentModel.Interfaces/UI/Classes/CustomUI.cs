namespace DocumentModel.UI;

/// <summary>
///   Defines CustomUI.
/// </summary>
public class CustomUI: ModelElement
{
  /// <summary>
  ///   onLoad
  /// </summary>
  public string? OnLoad { get; set; }
  /// <summary>
  ///   loadImage
  /// </summary>
  public string? LoadImage { get; set; }
  /// <summary>
  ///   RepurposedCommands.
  /// </summary>
  public RepurposedCommands? RepurposedCommands { get; set; }
  /// <summary>
  ///   Ribbon.
  /// </summary>
  public Ribbon? Ribbon { get; set; }
}