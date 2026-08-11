namespace DocumentModel;

/// <summary>
///   Represents binary data encoded as a Base64 string, used for embedding binary content in text-based formats.
/// </summary>
/// <remarks>
///   <para>
///   Base64 encoding converts binary data to ASCII characters using a 64-character alphabet (A-Z, a-z, 0-9, +, /).
///   The encoded string length is approximately 133% of the original binary size due to the encoding overhead.
///   Padding characters (=) are added to ensure the encoded string length is a multiple of 4.
///   </para>
///   <para>
///   This struct provides implicit conversions between Base64Binary and both string and byte array types,
///   making it seamless to work with binary data in different representations. The struct is immutable
///   and implements value equality based on the underlying byte sequence.
///   </para>
///   <para>
///   <b>Office Availability:</b> Base64 binary encoding is supported across all Office Open XML formats
///   including Word, Excel, and PowerPoint documents (Office 2007 and later). This is the standard
///   encoding method for embedding binary data in XML-based document formats.
///   </para>
/// </remarks>
[DataContract]
[JsonConverter(typeof(Base64BinaryJsonConverter))]
[SimpleType]
public partial class Base64Binary : IEquatable<Base64Binary>
{
  internal byte[] value = Array.Empty<byte>();

  /// <summary>
  ///   Initializes a new instance of the <see cref="Base64Binary"/> class with an empty byte array.
  /// </summary>
  /// <remarks>
  ///   This parameterless constructor is required for XML serialization.
  /// </remarks>
  public Base64Binary()
  {
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="Base64Binary"/> class from a Base64-encoded string.
  /// </summary>
  /// <param name="val">A Base64-encoded string.</param>
  public Base64Binary(string val)
  {
    value = Convert.FromBase64String(val);
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="Base64Binary"/> class from a byte array.
  /// </summary>
  /// <param name="val">The byte array to wrap.</param>
  public Base64Binary(byte[] val)
  {
    value = val;
  }

  /// <summary>
  ///   Gets the number of bytes represented by this value.
  /// </summary>
  public int Length => value?.Length ?? 0;

  /// <summary>
  ///   Implicitly converts a Base64Binary value to its Base64-encoded string representation.
  /// </summary>
  /// <param name="val">The Base64Binary value to convert.</param>
  /// <returns>
  ///   A Base64-encoded string containing only valid Base64 characters (A-Z, a-z, 0-9, +, /, =).
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The conversion produces a string where every 3 bytes of binary data becomes 4 Base64 characters.
  ///   The resulting string uses standard Base64 alphabet and includes padding (=) if necessary.
  ///   </para>
  ///   <para>
  ///   Example conversions:
  ///   <list type="bullet">
  ///   <item><description>byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F } → "SGVsbG8="</description></item>
  ///   <item><description>byte[] { 0xFF, 0xD8, 0xFF, 0xE0 } → "/9j/4A==" (JPEG header)</description></item>
  ///   <item><description>byte[] { } (empty) → "" (empty string)</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public static implicit operator string(Base64Binary val) => Convert.ToBase64String(val.value);

  /// <summary>
  ///   Implicitly converts a Base64-encoded string to a Base64Binary value.
  /// </summary>
  /// <param name="val">
  ///   A Base64-encoded string containing only valid Base64 characters.
  /// </param>
  /// <returns>A Base64Binary value containing the decoded binary data.</returns>
  /// <remarks>
  ///   <para>
  ///   The input string must be a valid Base64-encoded string using the standard Base64 alphabet.
  ///   The string length must be a multiple of 4 (after padding). Invalid Base64 strings will
  ///   throw a <see cref="FormatException"/> during conversion.
  ///   </para>
  ///   <para>
  ///   Valid Base64 characters: A-Z, a-z, 0-9, +, /, = (padding)
  ///   </para>
  ///   <para>
  ///   Example conversions:
  ///   <list type="bullet">
  ///   <item><description>"SGVsbG8=" → byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F }</description></item>
  ///   <item><description>"/9j/4A==" → byte[] { 0xFF, 0xD8, 0xFF, 0xE0 }</description></item>
  ///   <item><description>"" (empty) → byte[] { } (empty array)</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  /// <exception cref="FormatException">
  ///   Thrown when the input string is not a valid Base64-encoded string.
  /// </exception>
  public static implicit operator Base64Binary(string val) => new(val);

  /// <summary>
  ///   Implicitly converts a Base64Binary value to its underlying byte array representation.
  /// </summary>
  /// <param name="val">The Base64Binary value to convert.</param>
  /// <returns>
  ///   A byte array containing the decoded binary data.
  /// </returns>
  /// <remarks>
  ///   This conversion provides direct access to the raw binary data without encoding overhead.
  ///   The returned byte array is the actual underlying data, not a Base64-encoded representation.
  /// </remarks>
  public static implicit operator byte[](Base64Binary val) => val.value;

  /// <summary>
  ///   Implicitly converts a byte array to a Base64Binary value.
  /// </summary>
  /// <param name="val">
  ///   A byte array containing the binary data to be represented as Base64Binary.
  /// </param>
  /// <returns>A Base64Binary value wrapping the provided byte array.</returns>
  /// <remarks>
  ///   <para>
  ///   This conversion creates a Base64Binary wrapper around binary data. The data is stored
  ///   as-is and will be Base64-encoded only when converted to a string representation.
  ///   </para>
  ///   <para>
  ///   Null input is accepted and results in a Base64Binary with an empty byte array.
  ///   </para>
  /// </remarks>
  public static implicit operator Base64Binary(byte[] val) => new(val);

  /// <summary>
  /// Returns a hexadecimal string representation of the underlying byte array.
  /// </summary>
  /// <returns>A string containing the hexadecimal representation of the value. Returns an empty string if the value is null or
  /// empty.</returns>
  public override string ToString()
  {
    return Convert.ToBase64String(value);
  }

  /// <summary>
  ///   Determines whether this Base64Binary value is equal to another Base64Binary value.
  /// </summary>
  /// <param name="other">The Base64Binary value to compare with this instance.</param>
  /// <returns>
  ///   <see langword="true"/> if the byte sequences are equal; otherwise <see langword="false"/>.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   Equality is determined by comparing the underlying byte arrays element-by-element.
  ///   Two Base64Binary values are equal if and only if their byte arrays have the same length
  ///   and contain identical bytes in the same order.
  ///   </para>
  ///   <para>
  ///   This method uses sequence comparison, so Base64Binary values with identical binary content
  ///   are considered equal even if they were created from different sources (byte array vs. Base64 string).
  ///   </para>
  /// </remarks>
  public bool Equals(Base64Binary? other)
  {
    if (other == null)
      return false;
    return Enumerable.SequenceEqual(value, other.value);
  }

  /// <summary>
  /// Needed to correctly compare with object instances.
  /// </summary>
  /// <param name="obj"></param>
  /// <returns></returns>
  public override bool Equals(object? obj)
  {
    return obj is Base64Binary other && Equals(other);
  }

  /// <summary>
  ///   Returns a hash code for this Base64Binary value.
  /// </summary>
  /// <returns>
  ///   A 32-bit signed integer hash code calculated from the byte array contents.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The hash code is computed by combining the array length with each byte value using
  ///   <see cref="HashCode.Combine{T, T}"/>. This ensures that Base64Binary values with identical
  ///   byte content produce the same hash code, supporting proper usage in hash-based collections
  ///   like <see cref="IDictionary{TKey,TValue}"/> and <see cref="HashSet{T}"/>.
  ///   </para>
  ///   <para>
  ///   <b>Important:</b> Hash codes are only guaranteed to be equal for identical byte sequences
  ///   within the same application execution. Hash codes may differ across application runs or
  ///   .NET implementations.
  ///   </para>
  /// </remarks>
  public override int GetHashCode()
  {
    var result = value.Length;
    foreach (var item in value)
      result = HashCode.Combine(result, item);
    return result;
  }
}
