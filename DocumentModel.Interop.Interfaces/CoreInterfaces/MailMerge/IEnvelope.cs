
namespace DocumentModel.Interop.Core;
/// <summary>
/// Provides access to functionality that lets you send documents as email from Office applications.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb?view=office-pia"/>
public interface IEnvelopeVB
{
  /// <summary>
  /// Gets or sets the `Introduction` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb.introduction?view=office-pia"/>
  public string Introduction { get; set; }
  /// <summary>
  /// Gets a mail item that can be used to send the document as email.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb.item?view=office-pia"/>
  public object Item { get; }
  /// <summary>
  /// Gets the command bars collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb.commandbars?view=office-pia"/>
  public object CommandBars { get; }

  #region events	
  /// <summary>
  /// Occurs when `EnvelopeShow` is raised.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopeshow?view=office-pia"/>
  public event MsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;
  /// <summary>
  /// Occurs when `EnvelopeHide` is raised.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopehide?view=office-pia"/>
  public event MsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;
  #endregion events
}

