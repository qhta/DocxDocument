
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLValidationError` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a single validation error in a CustomXMLValidationErrors collection.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror?view=office-pia"/>
public partial class CustomXMLValidationError: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Node` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.node?view=office-pia"/>
  public CustomXMLNode Node { get; }
  /// <summary>
  /// Gets the `Text` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.text?view=office-pia"/>
  public string Text { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.type?view=office-pia"/>
  public CustomXMLValidationErrorType Type { get; }
  /// <summary>
  /// Gets the `ErrorCode` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.errorcode?view=office-pia"/>
  public int ErrorCode { get; }
}

