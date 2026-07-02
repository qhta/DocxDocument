namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the magnification setting for a Wordprocessing document.
/// This class provides properties for specifying the zoom type and zoom percentage, enabling control over the document's display magnification.
/// </summary>
[JsonConverter(typeof(ZoomJsonConverter))]
[OpenXmlType(typeof(DXW.Zoom))]
[DataContract]
[XmlRoot("Zoom", Namespace = "DocumentModel.Wordprocessing")]
public partial class Zoom : ModelElement<DXW.Zoom>, IEquatable<Zoom>
{
  private object? InternalValue;

  /// <summary>
  /// Zoom type, specifying the preset magnification mode.
  /// </summary>
  [OpenXmlProperty("Val")]
  public PresetZoom? Preset
  {
    get => InternalValue as PresetZoom?; 
    set => UpdateField(ref InternalValue, value, nameof(Preset));
  }
  

  /// <summary>
  /// Zoom percentage, specifying the magnification level as a percentage.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Zoom.Percent))]
  public Percent? Percent 
  { 
    get => InternalValue as Percent?; 
    set => UpdateField(ref InternalValue, value, nameof(Percent));
  }

  /// <summary>
  /// Converts an integer percentage value to a Zoom instance.
  /// </summary>
  /// <remarks>This operator enables implicit conversion from an integer representing a zoom percentage to a
  /// Zoom object. This allows assignment of an integer directly to a Zoom variable without explicit casting.</remarks>
  /// <param name = "value">The zoom level as a percentage. Must be a non-negative integer.</param>
  public static implicit operator Zoom(string value)
  {
    if (value.EndsWith("%"))
      return new Zoom
      {
        Percent = decimal.Parse(value.TrimEnd('%'))
      };
    else
      return new Zoom
      {
        Preset = (PresetZoom)Enum.Parse(typeof(PresetZoom), value)
      };
  }

  /// <summary>
  /// Checks if the Zoom instance represents a percentage zoom.
  /// </summary>
  /// <returns>True if the instance represents a percentage zoom; otherwise, false.</returns>
  public bool IsPercent() => Percent is not null;
  /// <summary>
  /// Checks if the Zoom instance represents a preset zoom.
  /// </summary>
  /// <returns>True if the instance represents a preset zoom; otherwise, false.</returns>
  public bool IsPreset() => Preset is not null;
  /// <summary>
  /// Implicitly converts a Zoom instance to its PresetZoom value.
  /// </summary>
  /// <param name = "zoom">Zoom instance to convert.</param>
  public static implicit operator PresetZoom(Zoom zoom) => zoom.Preset!.Value;
  /// <summary>
  /// Implicitly converts a PresetZoom value to a Zoom instance.
  /// </summary>
  /// <param name = "preset">PresetZoom value to convert.</param>
  public static implicit operator Zoom(PresetZoom preset) => new Zoom
  {
    Preset = preset
  };
  /// <summary>
  /// Implicitly converts a Zoom instance to its Percent value.
  /// </summary>
  /// <param name = "zoom">Zoom instance to convert.</param>
  public static implicit operator Percent(Zoom zoom) => zoom.Percent ?? default(Percent);
  /// <summary>
  /// Implicitly converts a Percent value to a Zoom instance.
  /// </summary>
  /// <param name = "percent">Percent value to convert.</param>
  public static implicit operator Zoom(Percent percent) => new Zoom
  {
    Percent = percent
  };
  /// <summary>
  /// Returns a string representation of the Zoom instance, prioritizing the Type property if set, otherwise the Percent property.
  /// </summary>
  /// <returns>String representation of the Zoom instance.</returns>
  public override string? ToString()
  {
    return Preset?.ToString() ?? Percent?.ToString() ?? base.ToString();
  }

  /// <summary>
  /// Static method to parse a string representation of a Zoom instance, returning a boolean indicating success or failure.
  /// </summary>
  /// <param name="str">The string representation of the Zoom instance.</param>
  /// <param name="value">The parsed Zoom instance if successful; otherwise, null.</param>
  /// <returns>True if the string was successfully parsed; otherwise, false.</returns>
  public static bool TryParse(string str, out Zoom? value)
  {
    if (str.EndsWith("%"))
    {
      if (decimal.TryParse(str.TrimEnd('%'), out var percent))
      {
        value = new Zoom
        {
          Percent = percent
        };
        return true;
      }
      value = null;
      return false;
    }
    else
    {
      if (Enum.TryParse<PresetZoom>(str, out var preset))
      {
        value = new Zoom
        {
          Preset = preset
        };
        return true;
      }
      value = null;
      return false;
    }
  }

  /// <summary>
  /// Parses a string representation of a Zoom instance, throwing a FormatException if the string is invalid.
  /// </summary>
  /// <param name="str">The string representation of the Zoom instance.</param>
  /// <returns>The parsed Zoom instance.</returns>
  /// <exception cref="FormatException">Thrown if the string is not a valid Zoom format.</exception>
  public static Zoom Parse(string str)
  {
    if (TryParse(str, out var value))
      return value!;
    throw new FormatException($"Invalid Zoom format: {str}");
  }
  /// <summary>
  /// Implements equality comparison between two Zoom instances.
  /// </summary>
  /// <param name = "other">Other Zoom instance to compare with.</param>
  /// <remarks>Compares the Type and Percent properties for equality.</remarks>
  /// <returns>True if the two Zoom instances are equal; otherwise, false.</returns>
  public bool Equals(Zoom? other)
  {
    if (other is null)
      return false;
    if (ReferenceEquals(this, other))
      return true;
    return base.Equals(other) && Preset == other.Preset && Percent == other.Percent;
  }
}