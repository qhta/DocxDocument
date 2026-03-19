using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoFileFindOptions
{
  msoOptionsNew = 1,
  msoOptionsAdd,
  msoOptionsWithin
}