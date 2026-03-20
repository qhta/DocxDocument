using System.Collections;

namespace DocumentModel.Interop.Core;

public interface MetaProperties: InteropDictionary<string, MetaProperty>
{
  MetaProperty GetItemByInternalName(string InternalName);
  string Validate();
  string ValidationError { get; }
  string SchemaXml { get; }
}