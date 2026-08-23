namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents language codes for three script types in WordprocessingML documents: regular (normal), complex (bidirectional), and East Asian scripts.
/// This class enables specification of language settings for spell checking, grammar checking, and text processing in multilingual documents.
/// </summary>
[OpenXmlType(typeof(DXW.Languages))]
[DataContract]
[XmlRoot("Languages", Namespace = "DocumentModel.Wordprocessing")]
public partial class Languages: ModelElement<DXW.Languages>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Languages(): base() { }

  /// <summary>
  /// Initializes a new instance of the Languages class with specified language representations, including optional
  /// support for bidirectional and East Asian languages.
  /// </summary>
  /// <param name = "val">The primary language value that identifies the language representation. Cannot be null.</param>
  /// <param name = "bidi">An optional value specifying the bidirectional text representation for the language, if applicable. Use this
  /// parameter to support languages such as Arabic or Hebrew.</param>
  /// <param name = "eastAsia">An optional value indicating the East Asian language representation, if applicable. Use this parameter to support
  /// languages such as Chinese, Japanese, or Korean.</param>
  public Languages(string val, string? bidi = null, string? eastAsia = null)
  {
    Val = val;
    Bidi = bidi;
    EastAsia = eastAsia;
  }

  /// <summary>
  /// Language code for all regular (normal) scripts, typically used for Western languages.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Languages.Val))]
  public string? Val
  {
    get => _Val ??= GetProperty<string?>(GetUpdatableElement()?.Val);
    set => UpdateField(ref _Val, value, nameof(Val));
  }

  private string? _Val;

  /// <summary>
  /// Language code for complex (bidirectional) scripts, such as Arabic, Hebrew, or Thai.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Languages.Bidi))]
  public string? Bidi
  {
    get => _Bidi ??= GetProperty<string?>(GetUpdatableElement()?.Bidi);
    set => UpdateField(ref _Bidi, value, nameof(Bidi));
  }

  private string? _Bidi;

  /// <summary>
  /// Language code for East Asian scripts, such as Chinese, Japanese, or Korean.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Languages.EastAsia))]
  public string? EastAsia
  {
    get => _EastAsia ??= GetProperty<string?>(GetUpdatableElement()?.EastAsia);
    set => UpdateField(ref _EastAsia, value, nameof(EastAsia));
  }

  private string? _EastAsia;

  /// <summary>
  /// Returns a string that represents the current object, including its value and any associated language properties.
  /// </summary>
  /// <remarks>Use this method to obtain a human-readable summary of the object's state for debugging or logging
  /// purposes. The output includes only properties that are not null.</remarks>
  /// <returns>A string containing the object's value and any non-null language properties, formatted as 'CS:{Bidi}' and
  /// 'EA:{EastAsia}', separated by commas.</returns>
  public override string ToString()
  {
    var stringList = new List<string>();
    if (Val != null)
      stringList.Add(Val);
    if (EastAsia != null)
      stringList.Add($"EastAsia: {EastAsia}");
    if (Bidi != null)
      stringList.Add($"Bidi: {Bidi}");
    return string.Join(", ", stringList);
  }

  /// <summary>
  /// Implicitly converts a nullable Languages enumeration value to its string representation.
  /// </summary>
  /// <remarks>This operator enables seamless conversion between Languages enumeration values and their string
  /// representations, which can simplify integration with APIs or components that require string input.</remarks>
  /// <param name = "languages">The nullable Languages enumeration value to convert. If the value is null, the result will also be null.</param>
  public static implicit operator string?(Languages? languages) => languages?.ToString();

  /// <summary>
  /// Implicitly converts a string representation of language codes and properties into a nullable Languages enumeration value.
  /// </summary>
  /// <param name = "value">The string representation of language codes and properties to convert.
  /// If the value is null or cannot be parsed, the result will be null.</param>
  public static implicit operator Languages?(string? value)
  {
    if (TryParse(value, out var languages))
      return languages;

    return null;
  }

  /// <summary>
  /// Parses a string containing language codes and associated properties into a <see cref = "Languages"/> object.
  /// </summary>
  /// <param name = "value">The string representation of language codes and properties to parse.</param>
  /// <returns>A <see cref = "Languages"/> object representing the parsed language codes and properties.</returns>
  /// <exception cref = "FormatException">Thrown if the input string is not in a valid format.</exception>
  public static Languages FromString(string value)
  {
    if (TryParse(value, out var languages))
      return languages!;

    throw new FormatException($"Invalid format for Languages: '{value}'");
  }

  /// <summary>
  /// Attempts to parse a string containing language codes and associated properties into a <see cref = "Languages"/>
  /// object.
  /// </summary>
  /// <remarks>The input string must follow a specific format: the first element is the language code, and any
  /// additional elements must begin with 'CS:' or 'EA:' to specify bidirectional or East Asian language properties,
  /// respectively. If the format is unrecognized, the method returns <see langword="false"/>.</remarks>
  /// <param name = "input">The input string to parse. Must be a comma-separated list where the first element is the language code, and
  /// subsequent elements may specify properties prefixed with 'CS:' for bidirectional languages or 'EA:' for East Asian
  /// languages. Cannot be null or empty.</param>
  /// <param name = "languages">When this method returns <see langword="true"/>, contains the parsed <see cref = "Languages"/> object with extracted
  /// values; otherwise, is <see langword="null"/>.</param>
  /// <returns><see langword="true"/> if the input string was successfully parsed into a <see cref = "Languages"/> object;
  /// otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string? input, out Languages? languages)
  {
    languages = null;
    if (string.IsNullOrEmpty(input))
      return false;

    var parts = input.Split(',').Select(p => p.Trim()).ToArray();
    if (parts.Length == 0)
      return false;

    var lang = new Languages
    {
      Val = parts[0]
    };
    for (int i = 1; i < parts.Length; i++)
    {
      var part = parts[i];
      if (part.StartsWith("EastAsia:"))
      {
        var ss = part.Split(':');
        if (ss.Length != 2)
          return false;

        lang.EastAsia = ss[1];
      }
      else if (part.StartsWith("Bidi:"))
      {
        var ss = part.Split(':');
        if (ss.Length != 2)
          return false;

        lang.Bidi = ss[1];
      }
      else
        return false; // Unrecognized format
    }
    languages = lang;
    return true;
  }
}