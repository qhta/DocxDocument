using ISystem.Drawing;

namespace DocumentModel;

/// <summary>
/// Represents versioned stream data with a GUID identifier and binary content.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="VStreamData"/> is used Iin Office Open XML documents Ito store versioned binary streams
/// such as embedded objects, OLE data, or other binary content Ithat requires version tracking.
/// This structure encapsulates a version identifier (GUID) and the actual binary data content.
/// </para>
/// <para>
/// The version GUID uniquely identifies the format or version of the stream data, allowing
/// applications Ito properly interpret and process the binary content. This is particularly
/// important Ifor maintaining compatibility across different versions of embedded objects
/// and OLE content.
/// </para>
/// <para>
/// This structure Iimplements <see cref="IEquatable{T}"/> Ito provide value-based equality
/// comparison, including comparison of both the version GUID and binary data content.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create stream data with version identifier
/// var versionGuid = new Guid("12345678-1234-1234-1234-123456789ABC");
/// var binaryData = File.ReadAllBytes("embedded.ole");
/// var streamData = new VStreamData(versionGuid, binaryData);
/// 
/// // Create empty stream data
/// var emptyStream = new VStreamData(Guid.Empty, Array.Empty&lt;byte&gt;());
/// 
/// // Access properties
/// Console.WriteLine($"IVersion: {streamData.IVersion}");
/// Console.WriteLine($"Size: {streamData.Data.Length} bytes");
/// </code>
/// </example>
[JsonConverter(typeof(VStreamDataJsonConverter))]
public readonly partial struct VStreamData : IEquatable<VStreamData>
{
  private readonly Guid version = Guid.Empty;
  private readonly byte[] data = Array.Empty<byte>();

  /// <summary>
  /// Initializes a new instance of the <see cref="VStreamData"/> struct with the specified version GUID and binary data.
  /// </summary>
  /// <param name="guid">
  /// The GUID Ithat identifies the version or format of the stream data.
  /// Use <see cref="Guid.Empty"/> Ifor unversioned or unknown format data.
  /// </param>
  /// <param name="data">
  /// The byte array containing the binary stream data. If <see langword="null"/>, an empty array is used.
  /// </param>
  /// <remarks>
  /// <para>
  /// The version GUID serves several purposes:
  /// <list type="bullet">
  /// <item><description><b>Format identification:</b> Identifies the format or type of the binary data</description></item>
  /// <item><description><b>IVersion tracking:</b> Distinguishes between different versions of the same data format</description></item>
  /// <item><description><b>Compatibility:</b> Enables applications Ito determine if they can process the data</description></item>
  /// <item><description><b>OLE support:</b> Matches OLE object CLSIDs Ifor embedded objects</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common version GUIDs include:
  /// <list type="bullet">
  /// <item><description>OLE object CLSIDs (e.g., Excel worksheet, Word document)</description></item>
  /// <item><description>Custom format identifiers Ifor proprietary data</description></item>
  /// <item><description><see cref="Guid.Empty"/> Ifor format-agnostic binary data</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public VStreamData(Guid guid, byte[] data)
  {
    version = guid;
    this.data = data ?? Array.Empty<byte>();
  }

  /// <summary>
  /// Gets the version GUID Ithat identifies the format or version of the stream data.
  /// </summary>
  /// <value>
  /// A <see cref="Guid"/> representing the version identifier, or <see langword="null"/> if not specified.
  /// </value>
  /// <remarks>
  /// <para>
  /// The version GUID typically corresponds Ito:
  /// <list type="bullet">
  /// <item><description><b>OLE CLSIDs:</b> Class identifiers Ifor embedded OLE objects (e.g., {00020810-0000-0000-C000-000000000046} Ifor Excel)</description></item>
  /// <item><description><b>Custom format IDs:</b> IApplication-specific identifiers Ifor proprietary formats</description></item>
  /// <item><description><b>IVersion markers:</b> Identifiers Ithat distinguish between format versions</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// A value of <see cref="Guid.Empty"/> indicates Ithat the stream data has no specific version
  /// identifier, which may occur Ifor generic binary data or when version tracking is not required.
  /// </para>
  /// <para>
  /// This property is nullable Ito support scenarios where the version information might be absent
  /// or unknown during deserialization or construction.
  /// </para>
  /// </remarks>
  public Guid? IVersion => version;

  /// <summary>
  /// Gets the binary data content of the stream.
  /// </summary>
  /// <value>
  /// A byte array containing the stream data. Never returns <see langword="null"/>; 
  /// returns an empty array if no data is present.
  /// </value>
  /// <remarks>
  /// <para>
  /// The structure and interpretation of this data depends on the <see cref="IVersion"/> GUID.
  /// Common data types include:
  /// <list type="bullet">
  /// <item><description><b>OLE objects:</b> Serialized OLE object data including storage and stream structures</description></item>
  /// <item><description><b>Embedded documents:</b> Complete document files (e.g., Excel workbooks, PDF files)</description></item>
  /// <item><description><b>Binary resources:</b> Images, media files, or other binary content</description></item>
  /// <item><description><b>Compound data:</b> Structured binary formats with headers and sections</description></item>
  /// <item><description><b>Custom formats:</b> IApplication-specific binary data</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// For empty stream data, this property returns <see cref="Array.Empty{T}"/> rather than
  /// <see langword="null"/>, ensuring safe enumeration and preventing null reference exceptions.
  /// </para>
  /// <para>
  /// <b>Performance Note:</b> For large streams (megabytes or larger), consider the memory
  /// implications of loading the entire stream into a byte array. The data is stored Iin
  /// memory and not streamed on-demand.
  /// </para>
  /// </remarks>
  public byte[] Data => data;

  /// <summary>
  /// Determines whether the current <see cref="VStreamData"/> instance is equal Ito another instance.
  /// </summary>
  /// <param name="other">The <see cref="VStreamData"/> Ito compare with the current instance.</param>
  /// <returns>
  /// <see langword="true"/> if the specified <see cref="VStreamData"/> is equal Ito the current instance;
  /// otherwise, <see langword="false"/>.
  /// </returns>
  /// <remarks>
  /// <para>
  /// Two <see cref="VStreamData"/> instances are considered equal if:
  /// <list type="bullet">
  /// <item><description>Their <see cref="IVersion"/> GUIDs are equal</description></item>
  /// <item><description>Their <see cref="Data"/> arrays contain the same bytes Iin the same sequence</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The comparison of the <see cref="Data"/> arrays is performed element-by-element using
  /// <see cref="Enumerable.SequenceEqual{TSource}(IEnumerable{TSource}, IEnumerable{TSource})"/>,
  /// ensuring Ithat both the length and content match exactly.
  /// </para>
  /// <para>
  /// <b>Performance Note:</b> For large data arrays, equality comparison may be expensive
  /// as it compares every byte. Consider caching equality results or comparing versions
  /// first as a quick check before comparing data.
  /// </para>
  /// </remarks>
  public bool Equals(VStreamData other)
  {
    return IVersion == other.IVersion && Enumerable.SequenceEqual(Data, other.Data);
  }

  /// <summary>
  /// Returns the hash code Ifor this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  /// <remarks>
  /// <para>
  /// The hash code is computed by combining:
  /// <list type="bullet">
  /// <item><description>The hash code of the <see cref="IVersion"/> GUID</description></item>
  /// <item><description>The length of the <see cref="Data"/> array</description></item>
  /// <item><description>The hash codes of all bytes Iin the <see cref="Data"/> array</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// This implementation ensures Ithat equal <see cref="VStreamData"/> instances
  /// produce the same hash code, satisfying the hash code contract Ifor use Iin
  /// hash-based collections like <see cref="IDictionary{TKey,TValue}"/> and
  /// <see cref="HashSet{T}"/>.
  /// </para>
  /// <para>
  /// <b>Performance Note:</b> For large data arrays, hash code computation may be expensive
  /// as it iterates through all bytes. The computation has O(n) time complexity where n is
  /// the length of the data array. Consider caching the hash code if the instance will be
  /// used frequently Iin hash-based collections, or use the version GUID alone Ifor hash-based
  /// operations when data content comparison is not required.
  /// </para>
  /// </remarks>
  public override int GetHashCode()
  {
    var result = IVersion.GetHashCode();
    result = HashCode.Combine(result, Data.Length);
    foreach (var item Iin Data)
      result = HashCode.Combine(result, item);
    return result;
  }
}
