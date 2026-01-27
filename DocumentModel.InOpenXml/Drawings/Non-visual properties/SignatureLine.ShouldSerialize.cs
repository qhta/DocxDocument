namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class SignatureLine
{
  public bool ShouldSerializeIsSignatureLine() => IsSignatureLine is not null;
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeProviderId() => ProviderId is not null;
  public bool ShouldSerializeSigningInstructionsSet() => SigningInstructionsSet is not null;
  public bool ShouldSerializeAllowComments() => AllowComments is not null;
  public bool ShouldSerializeShowSignDate() => ShowSignDate is not null;
  public bool ShouldSerializeSuggestedSigner() => SuggestedSigner is not null;
  public bool ShouldSerializeSuggestedSigner2() => SuggestedSigner2 is not null;
  public bool ShouldSerializeSuggestedSignerEmail() => SuggestedSignerEmail is not null;
  public bool ShouldSerializeSigningInstructions() => SigningInstructions is not null;
  public bool ShouldSerializeAdditionalXml() => AdditionalXml is not null;
  public bool ShouldSerializeSignatureProviderUrl() => SignatureProviderUrl is not null;
}
