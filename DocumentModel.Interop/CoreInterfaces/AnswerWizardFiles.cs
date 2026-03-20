
namespace DocumentModel.Interop.Core;

public partial interface AnswerWizardFiles: InteropObject
{
  public string this[int Index] { get; }
  public int Count { get; }
}
