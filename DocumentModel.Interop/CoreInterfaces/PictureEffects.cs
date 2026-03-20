using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PictureEffects` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PictureEffects: InteropCollection<PictureEffect>
{
}
