using System.Collections;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents a collection of EffectParameter objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameters?view=office-pia"/>
public partial interface IEffectParameters: IModelCollection<IEffectParameter>
{
}

