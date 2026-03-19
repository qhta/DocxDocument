using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000CDB09-0000-0000-C000-000000000046")]
[CoClass(typeof(CustomXMLPartsClass))]
public interface CustomXMLParts: _CustomXMLParts, _CustomXMLPartsEvents_Event
{
}