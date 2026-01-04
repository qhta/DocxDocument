namespace DocumentModel;

/// <summary>
///   Represents binary data encoded as a hexadecimal string for use in Office Open XML documents.
/// </summary>
/// <remarks>
///   <para>
///   HexBinary provides a type-safe wrapper for hexadecimal string values used throughout Office Open XML
///   documents. Unlike raw strings, HexBinary enforces that all characters are valid hexadecimal digits
///   and provides convenient conversion to and from byte arrays for binary data operations.
///   </para>
///   <para>
///   This type is commonly used in Office documents for:
///   <list type="bullet">
///   <item><description>Document element identifiers (comment IDs, paragraph IDs, revision IDs)</description></item>
///   <item><description>Binary data representation in XML format (images, embedded objects)</description></item>
///   <item><description>Cryptographic hashes and checksums for document integrity verification</description></item>
///   <item><description>Color values and other hexadecimal-encoded properties</description></item>
///   </list>
///   </para>
///   <para>
///   HexBinary values are case-insensitive but are typically stored in uppercase format. Each pair of
///   hexadecimal digits represents one byte, so the string length is always even and equals twice the
///   number of bytes in the underlying binary representation.
///   </para>
///   <para>
///   <b>Office Availability:</b> Hexadecimal binary encoding is supported across all Office Open XML
///   formats including Word, Excel, and PowerPoint documents (Office 2007 and later).
///   </para>
/// </remarks>
[JsonConverter(typeof(HexBinaryJsonConverter))]
public partial class HexBinary : IEquatable<HexBinary>
{
  private readonly byte[] value = Array.Empty<byte>();

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexBinary"/> class with an empty byte array.
  /// </summary>
  /// <remarks>
  ///   This parameterless constructor is required for XML serialization.
  /// </remarks>
  public HexBinary()
  {
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexBinary"/> class from a byte array.
  /// </summary>
  /// <param name="val">The byte array to wrap.</param>
  public HexBinary(byte[] val)
  {
    value = val ?? Array.Empty<byte>();
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexBinary"/> class from a hexadecimal string.
  /// </summary>
  /// <param name="val">A hexadecimal string with even length.</param>
  /// <exception cref="InvalidOperationException">
  ///   Thrown when the string length is odd.
  /// </exception>
  public HexBinary(string val)
  {
    if (string.IsNullOrEmpty(val))
    {
      value = Array.Empty<byte>();
      return;
    }

    if (val.Length % 2 != 0)
      throw new InvalidOperationException("HexBinary length must be even to convert from string to bytes");

    var result = new byte[val.Length / 2];
    for (var i = 0; i < result.Length; i++)
    {
      var b = Byte.Parse(val.Substring(i * 2, 2), NumberStyles.HexNumber);
      result[i] = b;
    }
    value = result;
  }

  /// <summary>
  ///   Gets the number of bytes represented by this hexadecimal value.
  /// </summary>
  public int Length => value?.Length ?? 0;

  /// <summary>
  /// Converts a HexBinary instance to its string representation.
  /// </summary>
  /// <remarks>This operator enables implicit conversion of a HexBinary object to a string, returning the
  /// hexadecimal string representation. If the value is null, an empty string is returned.</remarks>
  /// <param name="val">The HexBinary value to convert. Can be null.</param>
  public static implicit operator string(HexBinary val) => val?.ToString() ?? string.Empty;

  /// <summary>
  /// Defines an implicit conversion from a string containing hexadecimal characters to a HexBinary instance.
  /// </summary>
  /// <remarks>The input string must contain only valid hexadecimal characters (0-9, A-F, a-f). If the string is
  /// not a valid hexadecimal representation, an exception may be thrown during conversion.</remarks>
  /// <param name="val">A string representing a sequence of hexadecimal digits to be converted to a HexBinary value. Cannot be null.</param>
  public static implicit operator HexBinary(string val) => new(val);

  /// <summary>
  /// Converts a HexBinary instance to a byte array representing its value. 
  /// </summary>
  /// <remarks>If the specified HexBinary instance is null, this operator returns an empty byte array.</remarks>
  /// <param name="val">The HexBinary instance to convert. Can be null.</param>
  public static implicit operator byte[](HexBinary val) => val?.value ?? Array.Empty<byte>();

  /// <summary>
  /// Defines an implicit conversion from a byte array to a HexBinary instance.
  /// </summary>
  /// <remarks>This operator enables direct assignment of a byte array to a HexBinary variable without explicit
  /// casting. If the input array is null, an exception may be thrown by the HexBinary constructor.</remarks>
  /// <param name="val">The byte array to convert to a HexBinary instance. Cannot be null.</param>
  public static implicit operator HexBinary(byte[] val) => new(val);

  /// <summary>
  /// Defines an implicit conversion from a HexBinary instance to a byte, returning the first byte of the underlying
  /// value or 0 if the value is null or empty.
  /// </summary>
  /// <remarks>This operator enables direct assignment of a HexBinary object to a byte variable. If the
  /// HexBinary instance is null or its value is null or empty, the result is 0.</remarks>
  /// <param name="val">The HexBinary instance to convert to a byte.</param>
  public static implicit operator byte(HexBinary val) => val?.value[0] ?? 0;

  /// <summary>
  /// Defines an implicit conversion from a single byte value to a HexBinary instance.
  /// </summary>
  /// <remarks>The resulting HexBinary instance will represent a hexadecimal value containing only the specified
  /// byte. This allows direct assignment of a byte to a HexBinary variable without explicit casting.</remarks>
  /// <param name="val">The byte value to convert to a HexBinary instance.</param>
  public static implicit operator HexBinary(byte val) => new([val]);

  /// <summary>
  /// Defines an implicit conversion from a HexBinary instance to a ushort by parsing its string representation as a hexadecimal number.
  /// </summary>
  /// <remarks>This operator enables direct assignment of a HexBinary object to a ushort variable. If the
  /// HexBinary instance is null or its value is null or empty, the result is 0.</remarks>
  /// <param name="val">The HexBinary instance to convert to ushort.</param>
  public static implicit operator ushort(HexBinary val) => ushort.Parse(val?.ToString() ?? "0", NumberStyles.HexNumber, null);

  /// <summary>
  /// Converts a 16-bit unsigned integer to its equivalent hexadecimal binary representation as a HexBinary instance.
  /// </summary>
  /// <remarks>The resulting HexBinary will represent the value as a four-character uppercase hexadecimal
  /// string, padded with leading zeros if necessary.</remarks>
  /// <param name="val">The 16-bit unsigned integer value to convert to a HexBinary instance.</param>
  public static implicit operator HexBinary(ushort val) => new(val.ToString("X4"));

  /// <summary>
  /// Converts a <see cref="HexBinary"/> value to its equivalent 32-bit integer representation.
  /// </summary>
  /// <remarks>The conversion interprets the hexadecimal value as an unsigned integer. If <paramref name="val"/>
  /// is <see langword="null"/>, the result is 0.</remarks>
  /// <param name="val">The <see cref="HexBinary"/> value to convert to an integer.</param>
  public static implicit operator int(HexBinary val) => int.Parse(val?.ToString() ?? "0", NumberStyles.HexNumber, null);

  /// <summary>
  /// Defines an implicit conversion from a 32-bit integer to a HexBinary value using the integer's hexadecimal
  /// representation.
  /// </summary>
  /// <remarks>The resulting HexBinary will represent the integer as an 8-character uppercase hexadecimal
  /// string, padded with leading zeros if necessary.</remarks>
  /// <param name="val">The 32-bit integer value to convert to a HexBinary instance.</param>
  public static implicit operator HexBinary(int val) => new(val.ToString("X8"));

  /// <summary>
  /// Converts a <see cref="HexBinary"/> value to its equivalent 32-bit unsigned integer representation.
  /// </summary>
  /// <remarks>The conversion interprets the hexadecimal value as an unsigned integer. If <paramref name="val"/>
  /// is <see langword="null"/>, the result is 0.</remarks>
  /// <param name="val">The <see cref="HexBinary"/> value to convert to a 32-bit unsigned integer.</param>
  public static implicit operator uint(HexBinary val) => uint.Parse(val?.ToString() ?? "0", NumberStyles.HexNumber, null);

  /// <summary>
  /// Converts a 32-bit unsigned integer to its hexadecimal string representation as a HexBinary instance.
  /// </summary>
  /// <remarks>The resulting HexBinary will represent the value as an 8-character uppercase hexadecimal string,
  /// padded with leading zeros if necessary.</remarks>
  /// <param name="val">The 32-bit unsigned integer value to convert to a HexBinary.</param>
  public static implicit operator HexBinary(uint val) => new(val.ToString("X8"));

  /// <summary>
  /// Returns a hexadecimal string representation of the underlying byte array.
  /// </summary>
  /// <returns>A string containing the hexadecimal representation of the value. Returns an empty string if the value is null or
  /// empty.</returns>
  public override string ToString()
  {
    if (value.Length == 0)
      return string.Empty;

    var sb = new StringBuilder(value.Length * 2);
    foreach (var b in value)
    {
      sb.Append(b.ToString("X2"));
    }
    return sb.ToString();
  }

  /// <summary>
  /// Determines whether the current HexBinary instance is equal to another HexBinary instance.
  /// </summary>
  /// <param name="other">The HexBinary instance to compare with the current instance. Can be null.</param>
  /// <returns>true if the current instance and the other instance represent the same value; otherwise, false.</returns>
  public virtual bool Equals(HexBinary? other)
  {
    if (other == null)
      return false;
    return value.SequenceEqual(other.value);
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current HexBinary instance.
  /// </summary>
  /// <param name="obj">The object to compare with the current HexBinary instance.</param>
  /// <returns>true if the specified object is a HexBinary instance and is equal to the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    return Equals(obj as HexBinary);
  }

  /// <summary>
  /// Serves as the default hash function for the current object.
  /// </summary>
  /// <remarks>Use this method when inserting instances of this type into hash-based collections such as
  /// Dictionary or HashSet. The hash code is based on the contents of the underlying value, so objects with equal
  /// values will produce the same hash code.</remarks>
  /// <returns>A 32-bit signed integer hash code representing the current object.</returns>
  public override int GetHashCode()
  {
    var result = value.Length;
    foreach (var item in value)
      result = HashCode.Combine(result, item);
    return result;
  }
}