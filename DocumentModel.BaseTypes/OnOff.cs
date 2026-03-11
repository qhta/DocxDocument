namespace DocumentModel;

/// <summary>
/// Specific logical type for flag values switching between on and off states.
/// </summary>
[JsonConverter(typeof(OnOffJsonConverter))]
public partial record OnOff: IEquatable<byte>, IEquatable<bool>
{
  private byte value;

  /// <summary>
  /// Default constructor initializes the OnOff instance to an undefined state (value = 0).
  /// </summary>
  public OnOff()
  {
  }

  /// <summary>
  /// Value initialization constructor allows setting the internal byte value directly,
  /// which can represent on, off, or undefined states based on predefined constants.
  /// </summary>
  /// <param name="value"></param>
  public OnOff(byte value)
  {
    if (value>2)
      throw new ArgumentOutOfRangeException(nameof(value), value, 
        "Value must be 0 (Undefined), 1 (On), or 2 (Off).");
    this.value = value;
  }


  /// <summary>
  /// State is not defined,
  /// which can be used to represent an uninitialized state or a state where the on/off status is not applicable.
  /// </summary>
  public static readonly byte Undefined = 0;

  /// <summary>
  /// State is on, indicating that the feature or setting is active or enabled.
  /// </summary>
  public static readonly byte On = 1;

  /// <summary>
  /// State is off, indicating that the feature or setting is inactive or disabled.
  /// </summary>
  public static readonly byte Off = 2;

  /// <summary>
  /// Implicit conversion from byte to OnOff, allowing for easy assignment of byte values to OnOff variables.
  /// </summary>
  /// <param name="onOff">The OnOff instance to convert to a byte value.</param>
  public static implicit operator byte(OnOff onOff) => onOff.value;

  /// <summary>
  /// Defines an implicit conversion from a byte value to an OnOff instance.
  /// </summary>
  /// <param name="value">The byte value to convert to an OnOff instance.</param>
  public static implicit operator OnOff(byte value) => new(value);

  /// <summary>
  /// Compares the current OnOff instance with a byte value for equality, returning true if they represent the same state (On, Off, or Undefined).
  /// </summary>
  /// <param name="other">The byte value to compare with the current instance.</param>
  /// <returns>true if the current instance and the specified byte value represent the same state; otherwise, false.</returns>
  public bool Equals(byte other)
  {
    return value == other;
  }

  /// <summary>
  /// Determines whether the current instance and the specified Boolean value represent the same logical state.
  /// </summary>
  /// <param name="other">The Boolean value to compare with the current instance.</param>
  /// <returns>true if the logical state of the current instance matches the specified Boolean value; otherwise, false.</returns>
  public bool Equals(bool other)
  {
    return (value == On && other) || (value == Off && !other);
  }

  /// <summary>
  /// Parses the specified string and returns its equivalent OnOff value.
  /// </summary>
  /// <param name="value">The string representation to parse.
  /// Expected values are "on", "off", "undefined", or null/empty.</param>
  /// <returns>The OnOff value that corresponds to the specified string.</returns>
  /// <exception cref="FormatException">Thrown if the value is not a valid OnOff representation.</exception>
  public static OnOff Parse(string? value)
  {
    if (TryParse(value, out var result))
    {
      return result;
    }
    throw new FormatException($"Invalid OnOff value: '{value}'. Expected 'on', 'off', 'undefined' or null/empty.");
  }

  /// <summary>
  /// Attempts to convert the specified string representation to its equivalent OnOff value.
  /// </summary>
  /// <remarks>If the input string is null or empty, the result is set to an undefined OnOff value and the
  /// method returns true. The comparison is case-insensitive.</remarks>
  /// <param name="value">The string to parse. Can be "on", "off", or null/empty.</param>
  /// <param name="result">When this method returns, contains the OnOff value equivalent to the string, or an undefined value if the input is
  /// null or empty. This parameter is passed uninitialized.</param>
  /// <returns>true if the string was successfully parsed or is null/empty; otherwise, false.</returns>
  public static bool TryParse(string? value, out OnOff result)
  {
    if (string.IsNullOrEmpty(value) || value.Equals("undefined", StringComparison.OrdinalIgnoreCase))
    {
      result = new OnOff(Undefined);
      return true;
    }
    if (value.Equals("on", StringComparison.OrdinalIgnoreCase))
    {
      result = new OnOff(On);
      return true;
    }
    if (value.Equals("off", StringComparison.OrdinalIgnoreCase))
    {
      result = new OnOff(Off);
      return true;
    }
    result = default;
    return false;
  }

  /// <summary>
  /// Returns a string that represents the current value.
  /// </summary>
  /// <returns>A string representation of the value: "On" if the value is 1, "Off" if the value is 2, "Undefined" if the value is
  /// 0, or "Unknown(value)" for any other value.</returns>
  public override string ToString()
  {
    return value switch
    {
      1 => "On",
      2 => "Off",
      0 => "Undefined",
      _ => $"Unknown({value})"
    };
  }   
}