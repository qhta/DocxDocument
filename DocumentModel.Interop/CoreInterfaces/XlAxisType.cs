using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
[Guid("23D8FDAA-ABF3-4735-99B8-F234EA2BE64C")]
public enum XlAxisType
{
  xlCategory = 1,
  xlSeriesAxis = 3,
  xlValue = 2
}