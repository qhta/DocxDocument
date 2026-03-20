using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface MetaProperties
{
  public MetaProperty GetItemByInternalName(string InternalName);
  public string Validate();
}
