using System.Collections;

namespace DocumentModel.CustomXml;

/// <summary>
/// Represents the `CustomXMLValidationErrors` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLValidationError objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia"/>
public partial interface ICustomXMLValidationErrors: IModelCollection<ICustomXMLValidationError>
{
}

