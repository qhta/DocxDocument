
namespace DocumentModel.Interop.Core;

public partial interface LanguageSettings: InteropObject
{
  public int LanguageID { get; }
  public bool LanguagePreferredForEditing { get; }
}
