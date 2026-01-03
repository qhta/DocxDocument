namespace DocumentModel.VariantTypes;

/// <summary>
///   Represents a binary versioned stream that stores structured data with version tracking in Office documents.
/// </summary>
/// <remarks>
///   <para>
///   Versioned streams (VSTREAM) are data structures used in Office documents to store binary data with
///   explicit version information. They enable applications to maintain backward and forward compatibility
///   by tracking data format versions across different Office releases and add-in versions.
///   </para>
///   <para>
///   Versioned streams are commonly used in Office documents for:
///   <list type="bullet">
///   <item><description>Storing structured binary data that may evolve across Office versions</description></item>
///   <item><description>Embedding custom application data with version tracking capabilities</description></item>
///   <item><description>Preserving compatibility when document formats are updated</description></item>
///   <item><description>Enabling graceful degradation when opening documents in older Office versions</description></item>
///   <item><description>Maintaining metadata about embedded content and its format version</description></item>
///   </list>
///   </para>
///   <para>
///   The VSTREAM format is part of the OLE Automation variant type system and is particularly useful
///   for add-ins and extensions that need to store proprietary data within Office documents while
///   maintaining version awareness. The version attribute allows applications to determine whether
///   they can safely interpret the stream data or need to apply migration logic.
///   </para>
///   <para>
///   <b>Office Availability:</b> Versioned streams are supported across all modern Office applications
///   including Word, Excel, PowerPoint, and other Office suite products that handle OLE compound documents
///   and variant type data structures. Support is available in Office 2007 and later versions.
///   </para>
/// </remarks>
public interface VTVStreamData : IModelElement
{
  /// <summary>
  ///   Gets or sets the version identifier that specifies the format version of the versioned stream data.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The version attribute identifies the schema or format version of the data stored in the versioned
  ///   stream. This allows applications to:
  ///   <list type="bullet">
  ///   <item><description><b>Version detection:</b> Determine which version of data format is present in the stream</description></item>
  ///   <item><description><b>Compatibility checking:</b> Validate whether the application can read or write the data</description></item>
  ///   <item><description><b>Migration support:</b> Apply appropriate conversion logic when format versions differ</description></item>
  ///   <item><description><b>Graceful degradation:</b> Handle unknown versions appropriately (ignore, warn, or reject)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Version strings typically follow semantic versioning conventions (e.g., "1.0", "2.1.3") but can use
  ///   any application-specific versioning scheme. The format and interpretation of version identifiers
  ///   are determined by the application that creates and consumes the versioned stream.
  ///   </para>
  ///   <para>
  ///   Setting this to <see langword="null"/> indicates that no explicit version is specified, which may
  ///   imply the use of a default or implicit version scheme. Applications should define clear conventions
  ///   for handling missing version information to ensure predictable behavior.
  ///   </para>
  ///   <para>
  ///   <b>Best practices:</b>
  ///   <list type="bullet">
  ///   <item><description>Always specify a version when creating new versioned streams</description></item>
  ///   <item><description>Increment versions when making breaking changes to data format</description></item>
  ///   <item><description>Document version history and migration paths between versions</description></item>
  ///   <item><description>Implement version checking before attempting to read stream data</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public string? Version { get; set; }
}