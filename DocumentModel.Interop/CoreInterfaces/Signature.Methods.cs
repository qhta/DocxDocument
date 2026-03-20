
namespace DocumentModel.Interop.Core;

public partial interface Signature
{
  public void Delete();
  public void Sign(object varSigImg, object varDelSuggSigner, object varDelSuggSignerLine2, object varDelSuggSignerEmail);
  public void ShowDetails();
}
