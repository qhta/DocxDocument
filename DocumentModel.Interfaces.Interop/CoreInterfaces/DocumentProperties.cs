using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Collection of document properties.
/// </summary>
public interface DocumentProperties: InteropDictionary<string, DocumentProperty>
{
  /// <summary>
  /// Adds a new custom document property with the specified name, type, and value, optionally linking it to document
  /// content.
  /// </summary>
  /// <remarks>If a property with the specified name already exists, an exception may be thrown. Linking to
  /// content allows the property value to update automatically based on the linked source.</remarks>
  /// <param name="Name">The name of the custom property to add. Cannot be null or empty.</param>
  /// <param name="LinkToContent">true to link the property to document content; otherwise, false.</param>
  /// <param name="Type">The data type of the property. This is typically a value from the WdPropertyType enumeration.</param>
  /// <param name="Value">The value to assign to the property. This parameter is optional and can be null.</param>
  /// <param name="LinkSource">The source object to which the property is linked, if LinkToContent is true. This parameter is optional and can be
  /// null.</param>
  /// <returns>A DocumentProperty object representing the newly added custom property.</returns>
  public DocumentProperty Add(string Name, bool LinkToContent, object Type, object? Value = null, object? LinkSource = null);
}