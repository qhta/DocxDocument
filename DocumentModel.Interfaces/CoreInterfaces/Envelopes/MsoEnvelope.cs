
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the email envelope used to send documents from Office.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoenvelope?view=office-pia"/>
public partial interface MsoEnvelope: IMsoEnvelopeVB, IMsoEnvelopeVBEvents_Event
{
}

