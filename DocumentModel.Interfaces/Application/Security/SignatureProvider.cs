using System;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SignatureProvider` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISignatureProvider: IModelObject
{
}
