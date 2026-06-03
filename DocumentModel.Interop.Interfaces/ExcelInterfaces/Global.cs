using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[CoClass(typeof(GlobalClass))]
[Guid("000208D9-0000-0000-C000-000000000046")]
public interface Global: _Global
{
}