using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of debug unit tests.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts?view=office-pia
/// </remarks>
public partial interface MsoDebugOptions_UTs: InteropCollection<MsoDebugOptions_UT>
{
}
