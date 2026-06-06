
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a Microsoft Office system contact card.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.contactcard?view=office-pia"/>
public interface IContactCard: IInteropObject
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

  #region methods

  /// <summary>
  /// Closes the contact card.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.contactcard.close?view=office-pia"/>
  public void Close();
  /// <summary>
  /// Displays the contact card with the specified style and placement.
  /// </summary>
  /// <param name="CardStyle">The `CardStyle` parameter.</param>
  /// <param name="RectangleLeft">The `RectangleLeft` parameter.</param>
  /// <param name="RectangleRight">The `RectangleRight` parameter.</param>
  /// <param name="RectangleTop">The `RectangleTop` parameter.</param>
  /// <param name="RectangleBottom">The `RectangleBottom` parameter.</param>
  /// <param name="HorizontalPosition">The `HorizontalPosition` parameter.</param>
  /// <param name="ShowWithDelay">The `ShowWithDelay` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.contactcard.show?view=office-pia"/>
  public void Show
  (ContactCardStyle CardStyle, int RectangleLeft, int RectangleRight, int RectangleTop, int RectangleBottom,
    int HorizontalPosition, bool ShowWithDelay);

  #endregion methods
}

