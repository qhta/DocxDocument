namespace DocumentModel.VariantTypes;

/// <summary>
///   Represents clipboard data with format and size information used in Office documents.
/// </summary>
/// <remarks>
///   <para>
///   This interface defines clipboard data that can be embedded
///   in Office documents as variant type data. Clipboard data includes both the format identifier that
///   specifies how the data should be interpreted and the size of the data in bytes.
///   </para>
///   <para>
///   Clipboard data is commonly used in Office documents to store:
///   <list type="bullet">
///   <item><description>Embedded OLE objects and their native formats</description></item>
///   <item><description>Custom binary data with specific clipboard formats</description></item>
///   <item><description>Rich content that needs format information for proper rendering</description></item>
///   <item><description>Data transferred between Office applications via clipboard operations</description></item>
///   </list>
///   </para>
///   <para>
///   The format attribute typically corresponds to standard Windows clipboard formats (CF_*) or
///   custom registered formats. Common format values include CF_TEXT (1), CF_BITMAP (2), CF_METAFILEPICT (3),
///   and application-specific formats registered with the system.
///   </para>
/// </remarks>
public interface VTClipboardData : IModelElement
{
  /// <summary>
  ///   Gets or sets the clipboard format identifier that specifies how the data should be interpreted.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The format identifier corresponds to Windows clipboard formats, which can be either:
  ///   <list type="bullet">
  ///   <item><description><b>Standard formats:</b> Predefined system formats like CF_TEXT (1), CF_BITMAP (2), CF_METAFILEPICT (3)</description></item>
  ///   <item><description><b>Registered formats:</b> Custom formats registered via RegisterClipboardFormat API</description></item>
  ///   <item><description><b>Private formats:</b> Application-specific formats in the range 0xC000-0xFFFF</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   This value determines how applications should interpret and render the clipboard data.
  ///   Setting this to <see langword="null"/> indicates that no specific format is specified.
  ///   </para>
  /// </remarks>
  public Int32? Format { get; set; }

  /// <summary>
  ///   Gets or sets the size of the clipboard data in bytes.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The size indicates the length of the actual clipboard data content in bytes.
  ///   This information is useful for:
  ///   <list type="bullet">
  ///   <item><description>Pre-allocating memory buffers when reading the data</description></item>
  ///   <item><description>Validating data integrity during read/write operations</description></item>
  ///   <item><description>Determining storage requirements for the embedded content</description></item>
  ///   <item><description>Optimizing performance when handling large clipboard data</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Setting this to <see langword="null"/> indicates that the size is not specified or should be
  ///   determined dynamically from the actual data content.
  ///   </para>
  /// </remarks>
  public UInt32? Size { get; set; }
}