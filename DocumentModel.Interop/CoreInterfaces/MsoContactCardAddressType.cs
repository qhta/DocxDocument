using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[Guid("EC67AF3B-F2DF-4A52-9B85-E06A7FF28DB7")]
public enum MsoContactCardAddressType
{
  msoContactCardAddressTypeUnknown,
  msoContactCardAddressTypeOutlook,
  msoContactCardAddressTypeSMTP,
  msoContactCardAddressTypeIM
}