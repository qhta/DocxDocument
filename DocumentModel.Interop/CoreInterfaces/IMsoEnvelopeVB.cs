
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoEnvelopeVB` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb?view=office-pia` for Office interop details.
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
  /// Gets the `Item` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb.item?view=office-pia
  /// </remarks>
  public object Item { get; }
  /// <summary>
  /// Gets the `CommandBars` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevb.commandbars?view=office-pia
  /// </remarks>
  public object CommandBars { get; }
}
