
namespace DocumentModel.Interop.Core;

public interface IMsoContactCard: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Address { get; }
  MsoContactCardAddressType AddressType { get; }
  MsoContactCardType CardType { get; }
  object Parent { get; }
}