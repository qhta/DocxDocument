using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtColors` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolors?view=office-pia
/// </remarks>
public partial interface SmartArtColors: InteropDictionary<string, SmartArtColor>
{
}
