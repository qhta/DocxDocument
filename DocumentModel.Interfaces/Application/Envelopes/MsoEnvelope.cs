
namespace DocumentModel.Application;

/// <summary>
/// Represents the email envelope used to send documents from Office.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoenvelope?view=office-pia"/>
public partial interface IMsoEnvelope: IEnvelopeVB, IEnvelopeVBEvents_Event
{
}

