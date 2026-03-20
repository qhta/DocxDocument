
namespace DocumentModel.Interop.Core;

public interface LanguageSettings: InteropObject
{
  int LanguageID { get; }
  bool LanguagePreferredForEditing { get; }
}