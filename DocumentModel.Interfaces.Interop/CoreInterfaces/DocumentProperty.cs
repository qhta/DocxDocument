using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A single document property, which can be a built-in or custom property,
/// associated with a Microsoft Office document.
/// This interface provides methods and properties to manage the document property,
/// including its name, value, type, and linking behavior.
/// Document properties are used to store metadata about the document, such as author, title, subject,
/// and custom information defined by the user or application.
/// </summary>
public interface DocumentProperty: InteropObject
{
  /// <summary>
  /// Name of the document property.
  /// This is a string that identifies the property and is used to access it within the document's properties collection.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Gets or sets the underlying value represented by the property.
  /// </summary>
  public object Value { get; set; }

  /// <summary>
  /// Data type of the property value, specified as a member of the MsoDocProperties enumeration.
  /// </summary>
  public DocPropertyType Type { get; set; }

  /// <summary>
  /// Indicates whether the property is linked to document content.
  /// If true, the property value is automatically updated based on the linked content;
  /// if false, the property value is static and must be set manually.
  /// </summary>
  public bool LinkToContent { get; set; }

  /// <summary>
  /// The source object to which the property is linked, if LinkToContent is true.
  /// It can be any URL or identifier that represents the content source,
  /// such as a cell reference in a spreadsheet or a bookmark in a word processing document.
  /// </summary>
  public string LinkSource { get; set; }

  /// <summary>
  /// Deletes the current property.
  /// </summary>
  /// <remarks>Call this method to remove the object or release any associated resources. After calling this
  /// method, the object may no longer be usable, and further operations may result in exceptions or undefined behavior.
  /// The specific effects of deletion depend on the implementation.</remarks>
  public void Delete();

}
