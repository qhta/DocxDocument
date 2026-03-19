
namespace DocumentModel.Interop.Core;

public interface LanguageSettings: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  int LanguageID { get; }
  bool LanguagePreferredForEditing { get; }
  object Parent { get; }
}