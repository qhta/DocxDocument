namespace DocumentModel.Drawings;

/// <summary>
/// Defines the color map for drawing elements.
/// </summary>
public class ColorMap: ModelElement<DXD.ColorMap>
{
  /// <summary>
  /// Background 1 color mapping.
  /// </summary>
  public string? Background1 { get; set; }

  /// <summary>
  /// Text 1 color mapping.
  /// </summary>
  public string? Text1 { get; set; }

  /// <summary>
  /// Background 2 color mapping.
  /// </summary>
  public string? Background2 { get; set; }

  /// <summary>
  /// Text 2 color mapping.
  /// </summary>
  public string? Text2 { get; set; }

  /// <summary>
  /// Accent 1 color mapping.
  /// </summary>
  public string? Accent1 { get; set; }

  /// <summary>
  /// Accent 2 color mapping.
  /// </summary>
  public string? Accent2 { get; set; }

  /// <summary>
  /// Accent 3 color mapping.
  /// </summary>
  public string? Accent3 { get; set; }

  /// <summary>
  /// Accent 4 color mapping.
  /// </summary>
  public string? Accent4 { get; set; }

  /// <summary>
  /// Accent 5 color mapping.
  /// </summary>
  public string? Accent5 { get; set; }

  /// <summary>
  /// Accent 6 color mapping.
  /// </summary>
  public string? Accent6 { get; set; }

  /// <summary>
  /// Hyperlink color mapping.
  /// </summary>
  public string? Hyperlink { get; set; }

  /// <summary>
  /// Followed hyperlink color mapping.
  /// </summary>
  public string? FollowedHyperlink { get; set; }
}