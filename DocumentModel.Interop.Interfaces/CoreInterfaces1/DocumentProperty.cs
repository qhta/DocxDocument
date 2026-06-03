namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single document property, which is a metadata element associated with a document
/// that provides information about the document's attributes, characteristics, or content.
/// Document properties can include built-in properties such as title, author, and creation date,
/// as well as custom properties defined by users.
/// These properties are used to store and retrieve information about the document,
/// and they can be accessed and manipulated programmatically through the DocumentProperty interface.
/// </summary>
public interface DocumentProperty: InteropObject
{
  /// <summary>
  /// Gets the name associated with this instance.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// Gets the property type represented by this instance.
  /// </summary>
  public MsoPropertyType Type { get; }

  /// <summary>
  /// Gets or sets the value associated with this instance.
  /// </summary>
  public object Value { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether links to content are enabled.
  /// </summary>
  public bool LinkToContent { get; set; }

  /// <summary>
  /// Gets or sets the source URL or identifier associated with the link.
  /// </summary>
  public string LinkSource { get; set; }
}