namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines CustomUI.
/// </summary>
public class CustomUI: ModelElement
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