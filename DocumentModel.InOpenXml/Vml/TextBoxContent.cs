namespace DocumentModel.Vml;
/// <summary>
/// Represents the content of a text box using Vml notation.
/// </summary>
[DataContract]
[XmlRoot("TextBoxContent", Namespace = "DocumentModel.Vml")]
[JsonConverter(typeof(TextBoxContentJsonConverter))]
public partial class TextBoxContent : ModelElement
{
  /// <summary>
  /// Default constructor for the TextBoxContent class, initializing a new instance of the class.
  /// </summary>
  public TextBoxContent() { }

  /// <summary>
  /// Initializes a new instance of the TextBoxContent class with the specified string value.
  /// </summary>
  /// <param name="str">The string value to initialize the TextBoxContent instance with.</param>
  public TextBoxContent(string str)
  {
    Value = str;
  }

  /// <summary>
  /// Internal property to store any content.
  /// </summary>
  public object? Value { get; set; }

  /// <summary>
  /// Returns a string representation of the TextBoxContent instance, which is the string representation of the Value field.
  /// </summary>
  /// <returns>A string representation of the TextBoxContent instance.</returns>
  public override string? ToString()
  {
    return Value?.ToString();
  }

  /// <summary>
  /// Parses a string representation of an RGB color in the format "rgb(r,g,b)" and returns an TextBoxContent instance.
  /// </summary>
  /// <param name="str">The string representation of the RGB color.</param>
  /// <returns>An TextBoxContent instance.</returns>
  /// <exception cref="FormatException">Thrown when the string is not in a valid RGB color format.</exception>
  public static TextBoxContent Parse(string str)
  {
    if (TryParse(str, out var color))
      return color!;
    throw new FormatException($"Error parsing TextBoxContent: {str}");
  }

  /// <summary>
  /// Tries to parse a string representation of an RGB color in the format "rgb(r,g,b)" and returns a boolean indicating success or failure.
  /// </summary>
  /// <param name="str">The string representation of the RGB color.</param>
  /// <param name="value">When this method returns, contains the parsed TextBoxContent if the parsing succeeded, or null if the parsing failed.</param>
  /// <returns>True if the parsing succeeded; otherwise, false.</returns>
  public static bool TryParse(string str, out TextBoxContent? value)
  {
    value = new TextBoxContent { Value = str };
    return true;
  }

  /// <summary>
  /// Defines an implicit conversion from a string to a TextBoxContent instance, allowing for seamless assignment of string values to TextBoxContent properties.
  /// </summary>
  /// <param name="value">The string value to convert</param>
  public static implicit operator TextBoxContent(string value)
  {
    return new TextBoxContent { Value = value };
  }
}