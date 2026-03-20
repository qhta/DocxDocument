
namespace DocumentModel.Interop.Core;

public interface AnswerWizard: InteropObject
{
  AnswerWizardFiles Files { get; }
  void ClearFileList();
  void ResetFileList();
}