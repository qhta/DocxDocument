
namespace DocumentModel.Interop.Core;

public interface AnswerWizardFiles: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string this[int Index] { get; }
  int Count { get; }
  void Add(string FileName);
  void Delete(string FileName);
}