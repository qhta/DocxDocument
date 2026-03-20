
namespace DocumentModel.Interop.Core;

public interface AnswerWizard: InteropObject
{
  public AnswerWizardFiles Files { get; }
  public void ClearFileList();
  public void ResetFileList();
}
