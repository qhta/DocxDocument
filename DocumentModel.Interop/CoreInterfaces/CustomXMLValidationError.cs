
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLValidationError` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a single validation error in a CustomXMLValidationErrors collection.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror?view=office-pia
/// </remarks>
public partial interface CustomXMLValidationError: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Node` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.node?view=office-pia
  /// </remarks>
  public CustomXMLNode Node { get; }
  /// <summary>
  /// Gets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.text?view=office-pia
  /// </remarks>
  public string Text { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.type?view=office-pia
  /// </remarks>
  public MsoCustomXMLValidationErrorType Type { get; }
  /// <summary>
  /// Gets the `ErrorCode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.errorcode?view=office-pia
  /// </remarks>
  public int ErrorCode { get; }
}
