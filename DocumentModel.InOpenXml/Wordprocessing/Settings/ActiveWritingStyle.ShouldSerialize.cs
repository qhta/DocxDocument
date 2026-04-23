namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ActiveWritingStyle
{
  public bool ShouldSerializeApplicationName() => !String.IsNullOrEmpty(ApplicationName);
  public bool ShouldSerializeCheckStyle() => CheckStyle is not null;
  public bool ShouldSerializeDllVersion() => DllVersion is not null && ShouldSerialize(DllVersion);
  public bool ShouldSerializeVendorID() => VendorID is not null && ShouldSerialize(VendorID);
  public bool ShouldSerializeLanguage() => !String.IsNullOrEmpty(Language);
  public bool ShouldSerializeNaturalLanguageGrammarCheck() => NaturalLanguageGrammarCheck is not null;
}
