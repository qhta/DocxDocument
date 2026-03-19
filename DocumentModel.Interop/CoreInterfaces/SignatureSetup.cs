
namespace DocumentModel.Interop.Core;

public interface SignatureSetup: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  bool ReadOnly { get; }
  string Id { get; }
  string SignatureProvider { get; }
  string SuggestedSigner { get; set; }
  string SuggestedSignerLine2 { get; set; }
  string SuggestedSignerEmail { get; set; }
  string SigningInstructions { get; set; }
  bool AllowComments { get; set; }
  bool ShowSignDate { get; set; }
  string AdditionalXml { get; set; }
}