using System.Runtime.Serialization;
namespace DocumentModel;
/// <summary>
/// Basic color type. Contains name and RGB values.
/// </summary>

public interface AbstractColor
{
  /// <summary>
  ///   Gets RGB value of the color.
  /// </summary>
  public HexRgb? GetValue();

  /// <summary>
  /// Sets RGB value of the color.
  /// </summary>
  /// <param name="value">RGB hexadecimal value</param>
  public void FromRGB(HexRgb value);

  /// <summary>
  /// Sets color from string value;
  /// </summary>
  /// <param name="value"></param>
  public void FromString(string value);

  /// <summary>
  /// Gets value as string.
  /// </summary>
  /// <returns></returns>
  public string? ToString();

}
