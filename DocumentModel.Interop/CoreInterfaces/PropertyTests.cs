using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of file search criteria.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests?view=office-pia
/// </remarks>
public partial interface PropertyTests: InteropCollection<PropertyTest>
{
}
