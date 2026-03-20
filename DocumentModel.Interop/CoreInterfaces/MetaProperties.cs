using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface MetaProperties: InteropDictionary<string, MetaProperty>
{
  public string ValidationError { get; }
  public string SchemaXml { get; }
}
