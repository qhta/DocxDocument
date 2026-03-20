using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of picture effects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects?view=office-pia
/// </remarks>
public partial interface PictureEffects: InteropCollection<PictureEffect>
{
}
