
namespace DocumentModel.Interop.Core;

public interface LanguageSettings: InteropObject
{
  public int LanguageID { get; }
  public bool LanguagePreferredForEditing { get; }
}
