namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class SignatureLine
{
  public bool ShouldSerializeIsSignatureLine() => IsSignatureLine is not null;
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeProviderId() => !String.IsNullOrEmpty(ProviderId);
  public bool ShouldSerializeSigningInstructionsSet() => SigningInstructionsSet is not null;
  public bool ShouldSerializeAllowComments() => AllowComments is not null;
  public bool ShouldSerializeShowSignDate() => ShowSignDate is not null;
  public bool ShouldSerializeSuggestedSigner() => !String.IsNullOrEmpty(SuggestedSigner);
  public bool ShouldSerializeSuggestedSigner2() => !String.IsNullOrEmpty(SuggestedSigner2);
  public bool ShouldSerializeSuggestedSignerEmail() => !String.IsNullOrEmpty(SuggestedSignerEmail);
  public bool ShouldSerializeSigningInstructions() => !String.IsNullOrEmpty(SigningInstructions);
  public bool ShouldSerializeAdditionalXml() => !String.IsNullOrEmpty(AdditionalXml);
  public bool ShouldSerializeSignatureProviderUrl() => !String.IsNullOrEmpty(SignatureProviderUrl);
}
