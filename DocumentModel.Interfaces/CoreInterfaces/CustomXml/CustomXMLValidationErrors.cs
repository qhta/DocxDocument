using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `CustomXMLValidationErrors` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLValidationError objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia"/>
public partial interface CustomXMLValidationErrors: InteropCollection<CustomXMLValidationError>
{
}

