using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a collection of picture effects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects?view=office-pia"/>
public partial interface PictureEffects: InteropCollection<PictureEffect>
{
}

