
namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides access to functionality that lets you send documents as email from Office applications.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb?view=office-pia
/// </remarks>
public partial interface IMsoEnvelopeVB
{
  /// <summary>
  /// Gets or sets the `Introduction` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb.introduction?view=office-pia
  /// </remarks>
  public string Introduction { get; set; }
  /// <summary>
  /// Gets a mail item that can be used to send the document as email.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb.item?view=office-pia
  /// </remarks>
  public object Item { get; }
  /// <summary>
  /// Gets the command bars collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb.commandbars?view=office-pia
  /// </remarks>
  public object CommandBars { get; }
}
