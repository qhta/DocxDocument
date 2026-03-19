
namespace DocumentModel.Interop.Core;

public interface AnswerWizard: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  AnswerWizardFiles Files { get; }
  void ClearFileList();
  void ResetFileList();
}