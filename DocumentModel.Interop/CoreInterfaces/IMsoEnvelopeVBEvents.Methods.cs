
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoEnvelopeVBEvents` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoEnvelopeVBEvents
{
  /// <summary>
  /// Invokes `EnvelopeShow`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents.envelopeshow?view=office-pia
  /// </remarks>
  public void EnvelopeShow();
  /// <summary>
  /// Invokes `EnvelopeHide`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents.envelopehide?view=office-pia
  /// </remarks>
  public void EnvelopeHide();
}
