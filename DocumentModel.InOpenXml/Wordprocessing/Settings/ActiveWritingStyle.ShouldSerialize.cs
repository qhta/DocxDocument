namespace DocumentModel.Wordprocessing;

public partial class ActiveWritingStyle
{
  public bool ShouldSerializeApplicationName() => ApplicationName != null;
  public bool ShouldSerializeCheckStyle() => CheckStyle != null;
  public bool ShouldSerializeDllVersion() => DllVersion != null;
  public bool ShouldSerializeVendorID() => VendorID != null;
  public bool ShouldSerializeLanguage() => Language != null;
  public bool ShouldSerializeNaturalLanguageGrammarCheck() => NaturalLanguageGrammarCheck != null;
}
