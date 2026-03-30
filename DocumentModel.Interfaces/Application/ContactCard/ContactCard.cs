
namespace DocumentModel.Application;

/// <summary>
/// Represents a Microsoft Office system contact card.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.contactcard?view=office-pia"/>

/// <summary>
/// Represents a contact card.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocontactcard?view=office-pia"/>
public partial interface ContactCard : IModelObject
{
  /// <summary>
  /// Gets the `Address` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocontactcard.address?view=office-pia"/>
  public string Address { get; }
  /// <summary>
  /// Gets the `AddressType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocontactcard.addresstype?view=office-pia"/>
  public ContactCardAddressType AddressType { get; }
  /// <summary>
  /// Gets the `CardType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocontactcard.cardtype?view=office-pia"/>
  public ContactCardType CardType { get; }
}


