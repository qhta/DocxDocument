
namespace DocumentModel.Application;

/// <summary>
/// Provides access to functionality that lets you send documents as email from Office applications.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb?view=office-pia"/>
public partial interface EnvelopeVB: InteropObject
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
}

