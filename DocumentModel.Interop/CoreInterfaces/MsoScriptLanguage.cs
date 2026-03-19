using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoScriptLanguage
{
  msoScriptLanguageJava = 1,
  msoScriptLanguageVisualBasic,
  msoScriptLanguageASP,
  msoScriptLanguageOther
}