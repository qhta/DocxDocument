
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the email envelope used to send documents from Office.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoenvelope?view=office-pia
/// </remarks>
public partial interface MsoEnvelope: IMsoEnvelopeVB, IMsoEnvelopeVBEvents_Event
{
}
