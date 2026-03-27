using System.Reflection;

namespace DocumentModel;

/// <summary>
/// Represents a custom or built-in document property.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty?view=office-pia"/>
public partial interface DocumentProperty: InteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Returns or sets the value of a document property.
  /// </summary>
  /// <remarks>
  ///This property is read-only for built-in document properties; read/write for custom document properties.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.value?view=office-pia"/>
  public object? Value { get; set; }
  /// <summary>
  /// Returns or sets the document property type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.type?view=office-pia"/>
  public DocPropertyType Type { get; set; }
  /// <summary>
  /// Determine if the value of the custom document property is linked to the content of the container document.
  /// </summary>
  /// <remarks>
  /// This property applies only to custom document properties. For built-in document properties, the value of this property is False.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.linktocontent?view=office-pia"/>
  public bool LinkToContent { get; set; }
  /// <summary>
  /// Returns or sets the source of a linked custom document property.
  /// </summary>
  /// <remarks>
  /// This property applies only to custom document properties; you cannot use it with built-in document properties.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.linksource?view=office-pia"/>
  public string LinkSource { get; set; }
}
