
namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents?view=office-pia"/>
public partial interface IEnvelopeVBEvents: IModelObject
{
  /// <summary>
  /// Occurs when the envelope user interface is shown.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents.envelopeshow?view=office-pia"/>
  public void EnvelopeShow();
  /// <summary>
  /// Occurs when the envelope user interface is hidden.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents.envelopehide?view=office-pia"/>
  public void EnvelopeHide();
}

