using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum XlErrorBarType
{
  xlErrorBarTypeCustom = -4114,
  xlErrorBarTypeFixedValue = 1,
  xlErrorBarTypePercent = 2,
  xlErrorBarTypeStDev = -4155,
  xlErrorBarTypeStError = 4
}