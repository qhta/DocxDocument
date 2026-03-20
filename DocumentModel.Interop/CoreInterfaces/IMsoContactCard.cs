
namespace DocumentModel.Interop.Core;

public interface IMsoContactCard: InteropObject
{
  public string Address { get; }
  public MsoContactCardAddressType AddressType { get; }
  public MsoContactCardType CardType { get; }
}
