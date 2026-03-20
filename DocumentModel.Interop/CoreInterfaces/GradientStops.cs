using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of GradientStop objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops?view=office-pia
/// </remarks>
public partial interface GradientStops: InteropCollection<GradientStop>
{
}
