using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000CDB02-0000-0000-C000-000000000046")]
[CoClass(typeof(CustomXMLSchemaCollectionClass))]
public interface CustomXMLSchemaCollection: _CustomXMLSchemaCollection
{
}