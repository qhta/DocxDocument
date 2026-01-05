namespace DocumentModel;

/// <summary>
/// Represents clipboard data with format information, size, and binary content.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="VClipboardData"/> is used in Office Open XML documents to store clipboard data
/// that has been embedded in the document. This structure encapsulates the clipboard format,
/// the size of the data, and the actual binary content.
/// </para>
/// <para>
/// The clipboard format identifier corresponds to standard Windows clipboard formats
/// (e.g., CF_TEXT, CF_BITMAP, CF_METAFILEPICT) or custom registered formats.
/// </para>
/// <para>
/// This structure implements <see cref="IEquatable{T}"/> to provide value-based equality
/// comparison, including comparison of the binary data content.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create clipboard data for text format
/// var textData = new VClipboardData
/// {
///     Format = 1, // CF_TEXT
///     Data = Encoding.UTF8.GetBytes("Hello, World!"),
///     Size = 13
/// };
/// 
/// // Create clipboard data for bitmap format
/// var bitmapData = new VClipboardData
/// {
///     Format = 2, // CF_BITMAP
///     Data = bitmapBytes,
///     Size = (uint)bitmapBytes.Length
/// };
/// </code>
/// </example>
[JsonConverter(typeof(VClipboardDataJsonConverter))]
public readonly partial struct VClipboardData: IEquatable<VClipboardData>
{
  private readonly int format;
  private readonly byte[] data = Array.Empty<byte>();

  /// <summary>
  /// Initializes a new instance of the VClipboardData class with the specified clipboard format and associated data. 
  /// </summary>
  /// <param name="format">The clipboard format identifier that specifies the type of data contained. Common values correspond to standard
  /// clipboard formats.</param>
  /// <param name="data">The byte array containing the clipboard data for the specified format. Cannot be null.</param>
  ///   /// <remarks>
  /// <para>
  /// The format identifier corresponds to standard Windows clipboard formats:
  /// <list type="bullet">
  /// <item><description><b>1 (CF_TEXT):</b> Text format (ANSI)</description></item>
  /// <item><description><b>2 (CF_BITMAP):</b> Bitmap format (handle to GDI bitmap)</description></item>
  /// <item><description><b>3 (CF_METAFILEPICT):</b> Metafile picture format</description></item>
  /// <item><description><b>8 (CF_DIB):</b> Device Independent Bitmap</description></item>
  /// <item><description><b>13 (CF_UNICODETEXT):</b> Unicode text format</description></item>
  /// <item><description><b>14 (CF_ENHMETAFILE):</b> Enhanced metafile format</description></item>
  /// <item><description><b>Custom formats:</b> Values ≥ 0xC000 for registered formats</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public VClipboardData(int format, byte[] data)
  {
    this.format = format;
    this.data = data ?? Array.Empty<byte>();
  }

  /// <summary>
  /// Gets or sets the clipboard format identifier.
  /// </summary>
  /// <value>
  /// An integer representing the clipboard format, or <see langword="null"/> if not specified.
  /// </value>
  /// <remarks>
  /// <para>
  /// The format identifier corresponds to standard Windows clipboard formats:
  /// <list type="bullet">
  /// <item><description><b>1 (CF_TEXT):</b> Text format (ANSI)</description></item>
  /// <item><description><b>2 (CF_BITMAP):</b> Bitmap format (handle to GDI bitmap)</description></item>
  /// <item><description><b>3 (CF_METAFILEPICT):</b> Metafile picture format</description></item>
  /// <item><description><b>8 (CF_DIB):</b> Device Independent Bitmap</description></item>
  /// <item><description><b>13 (CF_UNICODETEXT):</b> Unicode text format</description></item>
  /// <item><description><b>14 (CF_ENHMETAFILE):</b> Enhanced metafile format</description></item>
  /// <item><description><b>Custom formats:</b> Values ≥ 0xC000 for registered formats</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If this property is <see langword="null"/>, the format is unspecified or unknown.
  /// </para>
  /// </remarks>
  public int Format => format;
  /// <summary>
  /// Gets or sets the size of the clipboard data in bytes.
  /// </summary>
  /// <value>
  /// An unsigned 32-bit integer representing the size of the data in bytes,
  /// or <see langword="null"/> if not specified.
  /// </value>
  /// <remarks>
  /// <para>
  /// This property typically matches the length of the <see cref="Data"/> array.
  /// However, in some cases it may differ if the data is compressed or if only
  /// a portion of the data is being represented.
  /// </para>
  /// <para>
  /// When serializing clipboard data, this value helps validate the integrity
  /// of the binary content.
  /// </para>
  /// </remarks>
  public UInt32 Size => data!=null ? (UInt32)data.Length : 0;

  /// <summary>
  /// Gets or sets the binary data content of the clipboard.
  /// </summary>
  /// <value>
  /// A byte array containing the clipboard data. Cannot be <see langword="null"/>.
  /// </value>
  /// <remarks>
  /// <para>
  /// The structure and interpretation of this data depends on the <see cref="Format"/> value.
  /// For example:
  /// <list type="bullet">
  /// <item><description><b>Text formats (CF_TEXT, CF_UNICODETEXT):</b> Contains text bytes in the appropriate encoding</description></item>
  /// <item><description><b>Bitmap formats (CF_DIB, CF_BITMAP):</b> Contains bitmap header and pixel data</description></item>
  /// <item><description><b>Metafile formats:</b> Contains metafile records and data</description></item>
  /// <item><description><b>Custom formats:</b> Application-specific binary data</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// For empty clipboard data, this should be an empty array rather than <see langword="null"/>.
  /// </para>
  /// </remarks>
  public byte[] Data => data;

  /// <summary>
  /// Determines whether the current <see cref="VClipboardData"/> instance is equal to another instance.
  /// </summary>
  /// <param name="other">The <see cref="VClipboardData"/> to compare with the current instance.</param>
  /// <returns>
  /// <see langword="true"/> if the specified <see cref="VClipboardData"/> is equal to the current instance;
  /// otherwise, <see langword="false"/>.
  /// </returns>
  /// <remarks>
  /// <para>
  /// Two <see cref="VClipboardData"/> instances are considered equal if:
  /// <list type="bullet">
  /// <item><description>Their <see cref="Format"/> values are equal</description></item>
  /// <item><description>Their <see cref="Size"/> values are equal</description></item>
  /// <item><description>Their <see cref="Data"/> arrays contain the same bytes in the same sequence</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The comparison of the <see cref="Data"/> arrays is performed element-by-element using
  /// <see cref="Enumerable.SequenceEqual{TSource}(IEnumerable{TSource}, IEnumerable{TSource})"/>,
  /// ensuring that both the length and content match exactly.
  /// </para>
  /// </remarks>
  public bool Equals(VClipboardData other)
  {
    return Format == other.Format && Size == other.Size && Enumerable.SequenceEqual(Data,other.Data);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  /// <remarks>
  /// <para>
  /// The hash code is computed by combining:
  /// <list type="bullet">
  /// <item><description>The hash code of the <see cref="Format"/> property</description></item>
  /// <item><description>The hash code of the <see cref="Size"/> property</description></item>
  /// <item><description>The length of the <see cref="Data"/> array</description></item>
  /// <item><description>The hash codes of all bytes in the <see cref="Data"/> array</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// This implementation ensures that equal <see cref="VClipboardData"/> instances
  /// produce the same hash code, satisfying the hash code contract.
  /// </para>
  /// <para>
  /// <b>Performance Note:</b> For large data arrays, hash code computation may be expensive
  /// as it iterates through all bytes. Consider caching the hash code if the instance
  /// will be used frequently in hash-based collections.
  /// </para>
  /// </remarks>
  public override int GetHashCode()
  {
    var result = HashCode.Combine(Format.GetHashCode(), Size.GetHashCode());
    result = HashCode.Combine(result, Data.Length);
    foreach (var item in Data)
      result = HashCode.Combine(result, item);
    return result;
  }
}