using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a collection of GradientStop objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops?view=office-pia"/>
public partial interface GradientStops: InteropCollection<GradientStop>
{
}

