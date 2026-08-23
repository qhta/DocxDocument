namespace DocumentModel;

/// <summary>
/// Represents a pair structure that consist of a string and an integer value.
/// </summary>
/// <remarks>
/// This struct provides a way to represent values that may be expressed as either text or numeric form,
/// commonly used in document models where formatting or content can accept multiple representations.
/// </remarks>
[DataContract]
[JsonConverter(typeof(StrNumPairJsonConverter))]
public partial struct StrNumPair : IEquatable<StrNumPair>
{
  /// <summary>
  /// Gets the string representation of the value.
  /// </summary>
  public string? Str { get; }

  /// <summary>
  /// Gets the numeric representation of the value.
  /// </summary>
  public int? Num { get; }

  /// <summary>
  /// Initializes a new instance of the <see cref="StrNumPair"/> struct with a string value.
  /// </summary>
  /// <param name="str">The string value in the format "(Str,Num)" or a plain string value.</param>
  /// <remarks>
  /// If the string is in the format "(Str,Num)", it will be parsed to extract both components.
  /// Otherwise, the entire string is used as the Str component and Num is set to null.
  /// </remarks>
  public StrNumPair(string? str)
  {
    if (str != null && str.StartsWith("(") && str.EndsWith(")"))
    {
      // Parse format: (Str,Num)
      var content = str.Substring(1, str.Length - 2);
      var parts = content.Split(',');

      if (parts.Length == 2)
      {
        Str = string.IsNullOrEmpty(parts[0]) ? null : parts[0];

        if (string.IsNullOrEmpty(parts[1]))
          Num = null;
        else if (int.TryParse(parts[1], out int numValue))
          Num = numValue;
        else
          Num = null;
      }
      else
      {
        Str = str;
        Num = null;
      }
    }
    else
    {
      Str = str;
      Num = null;
    }
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="StrNumPair"/> struct with both string and numeric values.
  /// </summary>
  /// <param name="str">The string value.</param>
  /// <param name="num">The numeric value.</param>
  public StrNumPair(string? str, int? num)
  {
    Str = str;
    Num = num;
  }

  /// <summary>
  /// Creates a new instance with the specified values. Used for deserialization.
  /// </summary>
  /// <param name="str">The string value.</param>
  /// <param name="num">The numeric value.</param>
  /// <returns>A new <see cref="StrNumPair"/> instance with the specified values.</returns>
  internal static StrNumPair SetValue(string? str, int? num)
  {
    return new StrNumPair(str, num);
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="StrNumPair"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="StrNumPair"/> value containing the string.</returns>
  public static implicit operator StrNumPair(string? value) => new StrNumPair(value);

  /// <summary>
  /// Implicitly converts a <see cref="StrNumPair"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="StrNumPair"/> value to convert.</param>
  /// <returns>The string representation.</returns>
  public static implicit operator string?(StrNumPair value) => value.Str;

  /// <summary>
  /// Implicitly converts an integer to a <see cref="StrNumPair"/> value.
  /// </summary>
  /// <param name="value">The integer to convert.</param>
  /// <returns>A <see cref="StrNumPair"/> value containing the number.</returns>
  public static implicit operator StrNumPair(int? value) => new StrNumPair("", value);

  /// <summary>
  /// Implicitly converts a <see cref="StrNumPair"/> value to an integer.
  /// </summary>
  /// <param name="value">The <see cref="StrNumPair"/> value to convert.</param>
  /// <returns>The numeric representation.</returns>
  public static implicit operator int?(StrNumPair value) => value.Num;

  #endregion

  /// <summary>
  /// Converts the value to its string representation in the format "(Str,Num)".
  /// </summary>
  /// <returns>The string representation in the format "(Str,Num)".</returns>
  public override string ToString() => $"({Str},{Num})";

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(StrNumPair other)
  {
    return String.Equals(Str, other.Str) && Num.Equals(other.Num);
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current object.
  /// </summary>
  /// <param name="obj">The object to compare with the current object.</param>
  /// <returns><see langword="true"/> if the specified object is equal to the current object; otherwise, <see langword="false"/>.</returns>
  public override bool Equals(object? obj)
  {
    return obj is StrNumPair other && Equals(other);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return HashCode.Combine(Str?.GetHashCode() ?? 0, Num?.GetHashCode() ?? 0);
  }

  /// <summary>
  /// Determines whether two <see cref="StrNumPair"/> values are equal.
  /// </summary>
  /// <param name="left">The first value to compare.</param>
  /// <param name="right">The second value to compare.</param>
  /// <returns><see langword="true"/> if the values are equal; otherwise, <see langword="false"/>.</returns>
  public static bool operator ==(StrNumPair left, StrNumPair right)
  {
    return left.Equals(right);
  }

  /// <summary>
  /// Determines whether two <see cref="StrNumPair"/> values are not equal.
  /// </summary>
  /// <param name="left">The first value to compare.</param>
  /// <param name="right">The second value to compare.</param>
  /// <returns><see langword="true"/> if the values are not equal; otherwise, <see langword="false"/>.</returns>
  public static bool operator !=(StrNumPair left, StrNumPair right)
  {
    return !left.Equals(right);
  }
}
