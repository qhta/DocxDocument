
namespace DocumentModel.Interop.Core;

public interface AnswerWizardFiles: InteropObject
{
  public string this[int Index] { get; }
  public int Count { get; }
  public void Add(string FileName);
  public void Delete(string FileName);
}
