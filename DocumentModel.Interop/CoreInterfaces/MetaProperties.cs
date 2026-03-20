using System.Collections;

namespace DocumentModel.Interop.Core;

public interface MetaProperties: InteropDictionary<string, MetaProperty>
{
  public MetaProperty GetItemByInternalName(string InternalName);
  public string Validate();
  public string ValidationError { get; }
  public string SchemaXml { get; }
}
