using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of debug unit tests.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts?view=office-pia"/>
public partial interface MsoDebugOptions_UTs: InteropCollection<MsoDebugOptions_UT>
{
}

