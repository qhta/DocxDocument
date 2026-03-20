
namespace DocumentModel.Interop.Core;

public interface IMsoContactCard: InteropObject
{
  string Address { get; }
  MsoContactCardAddressType AddressType { get; }
  MsoContactCardType CardType { get; }
}