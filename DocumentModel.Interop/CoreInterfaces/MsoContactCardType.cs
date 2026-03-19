using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[Guid("310803CD-C69D-4371-98C9-40CE4E9BFD5A")]
public enum MsoContactCardType
{
  msoContactCardTypeEnterpriseContact,
  msoContactCardTypePersonalContact,
  msoContactCardTypeUnknownContact,
  msoContactCardTypeEnterpriseGroup,
  msoContactCardTypePersonalDistributionList
}