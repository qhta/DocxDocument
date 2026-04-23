namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RubyProperties
{
  public bool ShouldSerializeRubyAlign() => RubyAlign is not null && ShouldSerialize(RubyAlign);
  public bool ShouldSerializePhoneticGuideTextFontSize() => PhoneticGuideTextFontSize is not null && ShouldSerialize(PhoneticGuideTextFontSize);
  public bool ShouldSerializePhoneticGuideRaise() => PhoneticGuideRaise is not null && ShouldSerialize(PhoneticGuideRaise);
  public bool ShouldSerializePhoneticGuideBaseTextSize() => PhoneticGuideBaseTextSize is not null && ShouldSerialize(PhoneticGuideBaseTextSize);
  public bool ShouldSerializeLanguageId() => !String.IsNullOrEmpty(LanguageId);
  public bool ShouldSerializeDirty() => Dirty is not null;
}
