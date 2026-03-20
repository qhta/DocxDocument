
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a contact card.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocontactcard?view=office-pia
/// </remarks>
public partial interface IMsoContactCard: InteropObject
{
  /// <summary>
  /// Gets the `Address` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocontactcard.address?view=office-pia
  /// </remarks>
  public string Address { get; }
  /// <summary>
  /// Gets the `AddressType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocontactcard.addresstype?view=office-pia
  /// </remarks>
  public MsoContactCardAddressType AddressType { get; }
  /// <summary>
  /// Gets the `CardType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocontactcard.cardtype?view=office-pia
  /// </remarks>
  public MsoContactCardType CardType { get; }
}
