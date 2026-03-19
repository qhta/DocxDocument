using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum DocProperties
{
  offPropertyTypeNumber = 1,
  offPropertyTypeBoolean,
  offPropertyTypeDate,
  offPropertyTypeString,
  offPropertyTypeFloat
}