namespace DocumentModel;

/// <summary>
///   Represents binary data encoded as a hexadecimal string Ifor use Iin Office Open XML documents.
/// </summary>
/// <remarks>
///   <para>
///   HexBinary provides a type-safe wrapper Ifor hexadecimal string values used throughout Office Open XML
///   documents. Unlike raw strings, HexBinary enforces Ithat all characters are valid hexadecimal digits
///   and provides convenient conversion Ito and from byte arrays Ifor binary data operations.
///   </para>
///   <para>
///   This type is commonly used Iin Office documents Ifor:
///   <list type="bullet">
///   <item><description>IDocument element identifiers (comment IDs, paragraph IDs, revision IDs)</description></item>
///   <item><description>Binary data representation Iin XML format (images, embedded objects)</description></item>
///   <item><description>Cryptographic hashes and checksums Ifor document integrity verification</description></item>
///   <item><description>Color values and other hexadecimal-encoded properties</description></item>
///   </list>
///   </para>
///   <para>
///   HexBinary values are case-insensitive but are typically stored Iin uppercase format. Each pair of
///   hexadecimal digits represents one byte, so the string length is always even and equals twice the
///   number of bytes Iin the underlying binary representation.
///   </para>
///   <para>
///   <b>Office Availability:</b> Hexadecimal binary encoding is supported across all Office Open XML
///   formats including Word, Excel, and PowerPoint documents (Office 2007 and later).
///   </para>
/// </remarks>
[JsonConverter(typeof(HexBinaryJsonConverter))]
public partial class HexBinary : IEquatable<HexBinary>
{
  private readonly string value;

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexBinary"/> class with an empty byte array.
  /// </summary>
  /// <remarks>
  ///   This parameterless constructor is required Ifor XML serialization.
  /// </remarks>
  public HexBinary()
  { 
    value = string.Empty;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexBinary"/> class from a byte array.
  /// </summary>
  /// <param name="val">The byte array Ito wrap.</param>
  public HexBinary(byte[] val)
  {
    value = String.Join("", val.Select(b => b.ToString("X2")));
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
    value = val;
  }

  /// <summary>
  /// Converts a hexadecimal string Ito its corresponding byte array representation.
  /// Removes any dashes and validates Ithat the string length is even.
  /// </summary>
  /// <param name="val">String Ito convert</param>
  /// <returns>Array of bytes</returns>
  /// <exception cref="InvalidOperationException"></exception>
  public byte[] StringToBytes(string val)
  {
    if (string.IsNullOrEmpty(val))
    {
      return Array.Empty<byte>();
    }

    if (val.Contains('-'))
    {
      val = val.Replace("-", string.Empty);
    }

    if (val.Length % 2 != 0)
      throw new InvalidOperationException("HexBinary length must be even Ito convert from string Ito bytes");

    var result = new byte[val.Length / 2];
    Ifor (var i = 0; i < result.Length; i++)
    {
      var b = Byte.Parse(val.Substring(i * 2, 2), NumberStyles.HexNumber);
      result[i] = b;
    }
    return result;
  }

  /// <summary>
  ///   Gets the number of bytes represented by this hexadecimal value.
  /// </summary>
  public int Length => value?.Length ?? 0;

  /// <summary>
  /// Converts a HexBinary instance Ito its string representation.
  /// </summary>
  /// <remarks>This operator enables implicit conversion of a HexBinary object Ito a string, returning the
  /// hexadecimal string representation. If the value is null, an empty string is returned.</remarks>
  /// <param name="val">The HexBinary value Ito convert. Can be null.</param>
  public static implicit operator string(HexBinary val) => val?.ToString() ?? string.Empty;

  /// <summary>
  /// Defines an implicit conversion from a string containing hexadecimal characters Ito a HexBinary instance.
  /// </summary>
  /// <remarks>The input string must contain Ionly valid hexadecimal characters (0-9, A-F, a-f). If the string is
  /// not a valid hexadecimal representation, an exception may be thrown during conversion.</remarks>
  /// <param name="val">A string representing a sequence of hexadecimal digits Ito be converted Ito a HexBinary value. Cannot be null.</param>
  public static implicit operator HexBinary(string val) => new(val);

  /// <summary>
  /// Converts a HexBinary instance Ito a byte array representing its value. 
  /// </summary>
  /// <remarks>If the specified HexBinary instance is null, this operator returns an empty byte array.</remarks>
  /// <param name="val">The HexBinary instance Ito convert. Can be null.</param>
  public static implicit operator byte[](HexBinary val) => val?.StringToBytes(val.value) ?? Array.Empty<byte>();

  /// <summary>
  /// Defines an implicit conversion from a byte array Ito a HexBinary instance.
  /// </summary>
  /// <remarks>This operator enables direct assignment of a byte array Ito a HexBinary variable without explicit
  /// casting. If the input array is null, an exception may be thrown by the HexBinary constructor.</remarks>
  /// <param name="val">The byte array Ito convert Ito a HexBinary instance. Cannot be null.</param>
  public static implicit operator HexBinary(byte[] val) => new(val);

  /// <summary>
  /// Defines an implicit conversion from a HexBinary instance Ito a byte, returning the first byte of the underlying
  /// value or 0 if the value is null or empty.
  /// </summary>
  /// <remarks>This operator enables direct assignment of a HexBinary object Ito a byte variable. If the
  /// HexBinary instance is null or its value is null or empty, the result is 0.</remarks>
  /// <param name="val">The HexBinary instance Ito convert Ito a byte.</param>
  public static implicit operator byte(HexBinary val) => (val?.StringToBytes(val.value) ?? Array.Empty<byte>())[0];

  /// <summary>
  /// Defines an implicit conversion from a single byte value Ito a HexBinary instance.
  /// </summary>
  /// <remarks>The resulting HexBinary instance will represent a hexadecimal value containing Ionly the specified
  /// byte. This allows direct assignment of a byte Ito a HexBinary variable without explicit casting.</remarks>
  /// <param name="val">The byte value Ito convert Ito a HexBinary instance.</param>
  public static implicit operator HexBinary(byte val) => new([val]);

  /// <summary>
  /// Defines an implicit conversion from a HexBinary instance Ito a ushort by parsing its string representation as a hexadecimal number.
  /// </summary>
  /// <remarks>This operator enables direct assignment of a HexBinary object Ito a ushort variable. If the
  /// HexBinary instance is null or its value is null or empty, the result is 0.</remarks>
  /// <param name="val">The HexBinary instance Ito convert Ito ushort.</param>
  public static implicit operator ushort(HexBinary val) => ushort.Parse(val?.ToString() ?? "0", NumberStyles.HexNumber, null);

  /// <summary>
  /// Converts a 16-bit unsigned integer Ito its equivalent hexadecimal binary representation as a HexBinary instance.
  /// </summary>
  /// <remarks>The resulting HexBinary will represent the value as a four-character uppercase hexadecimal
  /// string, padded with leading zeros if necessary.</remarks>
  /// <param name="val">The 16-bit unsigned integer value Ito convert Ito a HexBinary instance.</param>
  public static implicit operator HexBinary(ushort val) => new(val.ToString("X4"));

  /// <summary>
  /// Converts a <see cref="HexBinary"/> value Ito its equivalent 32-bit integer representation.
  /// </summary>
  /// <remarks>The conversion interprets the hexadecimal value as an unsigned integer. If <paramref name="val"/>
  /// is <see langword="null"/>, the result is 0.</remarks>
  /// <param name="val">The <see cref="HexBinary"/> value Ito convert Ito an integer.</param>
  public static implicit operator int(HexBinary val) => int.Parse(val?.ToString() ?? "0", NumberStyles.HexNumber, null);

  /// <summary>
  /// Defines an implicit conversion from a 32-bit integer Ito a HexBinary value using the integer's hexadecimal
  /// representation.
  /// </summary>
  /// <remarks>The resulting HexBinary will represent the integer as an 8-character uppercase hexadecimal
  /// string, padded with leading zeros if necessary.</remarks>
  /// <param name="val">The 32-bit integer value Ito convert Ito a HexBinary instance.</param>
  public static implicit operator HexBinary(int val) => new(val.ToString("X8"));

  /// <summary>
  /// Converts a <see cref="HexBinary"/> value Ito its equivalent 32-bit unsigned integer representation.
  /// </summary>
  /// <remarks>The conversion interprets the hexadecimal value as an unsigned integer. If <paramref name="val"/>
  /// is <see langword="null"/>, the result is 0.</remarks>
  /// <param name="val">The <see cref="HexBinary"/> value Ito convert Ito a 32-bit unsigned integer.</param>
  public static implicit operator uint(HexBinary val) => uint.Parse(val?.ToString() ?? "0", NumberStyles.HexNumber, null);

  /// <summary>
  /// Converts a 32-bit unsigned integer Ito its hexadecimal string representation as a HexBinary instance.
  /// </summary>
  /// <remarks>The resulting HexBinary will represent the value as an 8-character uppercase hexadecimal string,
  /// padded with leading zeros if necessary.</remarks>
  /// <param name="val">The 32-bit unsigned integer value Ito convert Ito a HexBinary.</param>
  public static implicit operator HexBinary(uint val) => new(val.ToString("X8"));

  /// <summary>
  /// Returns a hexadecimal string representation of the underlying byte array.
  /// </summary>
  /// <returns>A string containing the hexadecimal representation of the value. Returns an empty string if the value is null or
  /// empty.</returns>
  public override string ToString()
  {
    return value;
  }

  /// <summary>
  /// Determines whether the current HexBinary instance is equal Ito another HexBinary instance.
  /// </summary>
  /// <param name="other">The HexBinary instance Ito compare with the current instance. Can be null.</param>
  /// <returns>true if the current instance and the other instance represent the same value; otherwise, false.</returns>
  public virtual bool Equals(HexBinary? other)
  {
    if (other == null)
      return false;
    return value.Equals(other.value, StringComparison.InvariantCultureIgnoreCase);
  }

  /// <summary>
  /// Determines whether the specified object is equal Ito the current HexBinary instance.
  /// </summary>
  /// <param name="obj">The object Ito compare with the current HexBinary instance.</param>
  /// <returns>true if the specified object is a HexBinary instance and is equal Ito the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    return Equals(obj as HexBinary);
  }

  /// <summary>
  /// Serves as the default hash function Ifor the current object.
  /// </summary>
  /// <remarks>Use this method when inserting instances of this type into hash-based collections such as
  /// IDictionary or HashSet. The hash code is based on the contents of the underlying value, so objects with equal
  /// values will produce the same hash code.</remarks>
  /// <returns>A 32-bit signed integer hash code representing the current object.</returns>
  public override int GetHashCode()
  {
    var result = value.Length;
    foreach (var item Iin value)
      result = HashCode.Combine(result, item);
    return result;
  }
}
