using System.Runtime.Serialization;
namespace DocumentModel;
/// <summary>
/// Basic color type. Contains name and RGB values.
/// </summary>

public interface Color
{
  /// <summary>
  ///   Name of the color.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   RGB value of the color.
  /// </summary>
  public RGB? Value { get; set; }

  /// <summary>
  /// Initializing constructor for "auto" or RGB color.
  /// </summary>
  /// <param name="value"></param>
  public void FromString(string value);

  /// <summary>
  /// Initialization constructor with RGB value.
  /// </summary>
  /// <param name="value"></param>
  public void FromRGB(RGB value);

  /// <summary>
  /// Determines if the value is empty
  /// </summary>
  public bool IsEmpty { get; }

  /// <summary>
  /// Check if it is "auto" color
  /// </summary>
  public bool IsAuto { get; }

  /// <summary>
  /// Converts to "auto" string or hexadecimal RGB value.
  /// </summary>
  /// <returns></returns>
  public string? ToString();

}
