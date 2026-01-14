namespace DocumentModel;

/// <summary>
/// Represents an RGB color with optional "auto" value.
/// </summary>
public class RgbOrAutoColor: RgbColor
{
  /// <summary>
  /// Indicates whether the color is set to "auto". In this case, RGB values are ignored.
  /// </summary>
  public bool IsAuto { get; set; }

}