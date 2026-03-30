using System.Collections;

namespace DocumentModel.Drawings.SmartArt;

/// <summary>
/// Represents the `SmartArtColors` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolors?view=office-pia"/>
public partial interface ISmartArtColors: IModelCollection<ISmartArtColor>
{
}

