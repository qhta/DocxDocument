
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents?view=office-pia
/// </remarks>
public partial interface IMsoEnvelopeVBEvents
{
  /// <summary>
  /// Occurs when the envelope user interface is shown.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents.envelopeshow?view=office-pia
  /// </remarks>
  public void EnvelopeShow();
  /// <summary>
  /// Occurs when the envelope user interface is hidden.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents.envelopehide?view=office-pia
  /// </remarks>
  public void EnvelopeHide();
}
