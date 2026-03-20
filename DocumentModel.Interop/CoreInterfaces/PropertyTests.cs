using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PropertyTests` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PropertyTests: InteropCollection<PropertyTest>
{
}
