namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class ActiveWritingStyle
{
  public bool ShouldSerializeApplicationName() => ApplicationName is not null;
  public bool ShouldSerializeCheckStyle() => CheckStyle is not null;
  public bool ShouldSerializeDllVersion() => DllVersion is not null;
  public bool ShouldSerializeVendorID() => VendorID is not null;
  public bool ShouldSerializeLanguage() => Language is not null;
  public bool ShouldSerializeNaturalLanguageGrammarCheck() => NaturalLanguageGrammarCheck is not null;
}
