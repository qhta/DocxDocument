namespace DocumentModel;

/// <summary>
///   Represents an extension element that enables future extensibility and custom functionality in Office documents.
/// </summary>
/// <remarks>
///   This interface defines an extension element that allows documents
///   and Office UI customizations to include additional data, functionality, or features not defined in the base
///   schema. Extensions are identified by a URI (Uniform Resource Identifier) that specifies the namespace or
///   type of the extension, enabling Office applications to recognize and process custom extensions while maintaining
///   backward compatibility with applications that don't support them. This extensibility mechanism is fundamental
///   to Office's evolution, allowing new features to be added without breaking existing documents or requiring
///   schema changes that would invalidate older content. Extensions can contain custom XML data, reference external
///   schemas, or define application-specific behaviors that extend the standard Office functionality. Common uses
///   include adding metadata, implementing custom features for specific industries or workflows, integrating with
///   third-party systems, or enabling preview features before they become part of the core Office schema. Applications
///   that don't recognize a particular extension URI can safely ignore the extension content, ensuring documents
///   remain functional even when opened in older or different Office versions. This forward-compatible design
///   enables innovation while preserving document interoperability across different Office versions and platforms.
/// </remarks>
public interface Extension
{
  /// <summary>
  ///   Gets or sets the URI that identifies the type or namespace of this extension.
  /// </summary>
  /// <remarks>
  ///   The URI serves as a unique identifier that specifies what type of extension this is and how it should
  ///   be processed. The URI typically follows a namespace format (e.g., "http://schemas.microsoft.com/office/...")
  ///   that ensures uniqueness and provides context about the extension's origin and purpose. Office applications
  ///   use this URI to determine whether they can process the extension content. If an application recognizes
  ///   the URI, it can access and interpret the extension data; if not, it can safely ignore the extension
  ///   without affecting the document's core functionality. This URI-based identification system is crucial for
  ///   maintaining document compatibility across different Office versions and enabling incremental feature
  ///   adoption without requiring universal support for all extensions.
  /// </remarks>
  public string? Uri { get; set; }
}