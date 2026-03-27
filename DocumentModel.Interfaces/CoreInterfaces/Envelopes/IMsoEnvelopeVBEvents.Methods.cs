
namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents?view=office-pia"/>
public partial interface EnvelopeVBEvents: InteropObject
{
  /// <summary>
  /// Occurs when the envelope user interface is shown.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents.envelopeshow?view=office-pia"/>
  public void EnvelopeShow();
  /// <summary>
  /// Occurs when the envelope user interface is hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents.envelopehide?view=office-pia"/>
  public void EnvelopeHide();
}

