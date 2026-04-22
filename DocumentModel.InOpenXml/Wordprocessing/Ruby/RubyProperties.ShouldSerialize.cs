namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RubyProperties
{
  public bool ShouldSerializeRubyAlign() => RubyAlign is not null;
  public bool ShouldSerializePhoneticGuideTextFontSize() => PhoneticGuideTextFontSize is not null;
  public bool ShouldSerializePhoneticGuideRaise() => PhoneticGuideRaise is not null;
  public bool ShouldSerializePhoneticGuideBaseTextSize() => PhoneticGuideBaseTextSize is not null;
  public bool ShouldSerializeLanguageId() => !String.IsNullOrEmpty(LanguageId);
  public bool ShouldSerializeDirty() => Dirty is not null;
}
