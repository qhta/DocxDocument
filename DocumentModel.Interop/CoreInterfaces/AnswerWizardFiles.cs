
namespace DocumentModel.Interop.Core;

public interface AnswerWizardFiles: InteropObject
{
  string this[int Index] { get; }
  int Count { get; }
  void Add(string FileName);
  void Delete(string FileName);
}