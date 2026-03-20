
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MsoEnvelope` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoenvelope?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MsoEnvelope: IMsoEnvelopeVB, IMsoEnvelopeVBEvents_Event
{
}
