
namespace DocumentModel.Interop.Core;

public partial interface SignatureSetup: InteropObject
{
  public bool ReadOnly { get; }
  public string Id { get; }
  public string SignatureProvider { get; }
  public string SuggestedSigner { get; set; }
  public string SuggestedSignerLine2 { get; set; }
  public string SuggestedSignerEmail { get; set; }
  public string SigningInstructions { get; set; }
  public bool AllowComments { get; set; }
  public bool ShowSignDate { get; set; }
  public string AdditionalXml { get; set; }
}
