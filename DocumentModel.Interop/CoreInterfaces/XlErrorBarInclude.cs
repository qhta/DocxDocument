using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum XlErrorBarInclude
{
  xlErrorBarIncludeBoth = 1,
  xlErrorBarIncludeMinusValues = 3,
  xlErrorBarIncludeNone = -4142,
  xlErrorBarIncludePlusValues = 2
}