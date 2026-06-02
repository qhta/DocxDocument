using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of GradientStop objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops?view=office-pia"/>
public partial interface IGradientStops: InteropCollection<GradientStop>
{
}

