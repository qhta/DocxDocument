namespace DocumentModel.Vml;
/// <summary>
/// Represents an RGB color using Vml notation e.g. rgb(0,255,0)
/// </summary>
[DataContract]
[XmlRoot("RgbColor", Namespace = "DocumentModel.Vml")]
[JsonConverter(typeof(RgbColorJsonConverter))]
public partial class RgbColor : ModelElement
{
  /// <summary>
  /// Gets or sets the RGB color value in hexadecimal format (e.g., #RRGGBB).
  /// </summary>
  private HexColor? Value;

  /// <summary>
  /// Returns a string representation of the RGB color in the format "rgb(r,g,b)".
  /// </summary>
  /// <returns>A string representation of the RGB color.</returns>
  public override string ToString()
  {
    return $"rgb({Value?.R},{Value?.G},{Value?.B})";
  }

  /// <summary>
  /// Parses a string representation of an RGB color in the format "rgb(r,g,b)" and returns an RgbColor instance.
  /// </summary>
  /// <param name="str">The string representation of the RGB color.</param>
  /// <returns>An RgbColor instance.</returns>
  /// <exception cref="FormatException">Thrown when the string is not in a valid RGB color format.</exception>
  public static RgbColor Parse(string str)
  {
    if (TryParse(str, out var color))
      return color!;
    throw new FormatException($"Invalid RGB color format: {str}");
  }

  /// <summary>
  /// Tries to parse a string representation of an RGB color in the format "rgb(r,g,b)" and returns a boolean indicating success or failure.
  /// </summary>
  /// <param name="str">The string representation of the RGB color.</param>
  /// <param name="color">When this method returns, contains the parsed RgbColor if the parsing succeeded, or null if the parsing failed.</param>
  /// <returns>True if the parsing succeeded; otherwise, false.</returns>
  public static bool TryParse(string str, out RgbColor? color)
  {
    color = null;
    if (string.IsNullOrWhiteSpace(str))
      return false;
    // Check if the string starts with "rgb(" and ends with ")"
    if (!str.StartsWith("rgb(", StringComparison.OrdinalIgnoreCase) || !str.EndsWith(")"))
      return false;
    // Extract the content inside the parentheses
    var content = str.Substring(4, str.Length - 5);
    var parts = content.Split(',');
    if (parts.Length != 3)
      return false;
    // Try to parse each part as an integer
    if (Byte.TryParse(parts[0].Trim(), out byte r) &&
        Byte.TryParse(parts[1].Trim(), out byte g) &&
        Byte.TryParse(parts[2].Trim(), out byte b))
    {
      // Create a new RgbColor instance
      color = new RgbColor { Value = new HexColor(r, g, b) };
      return true;
    }
    return false;
  }
}