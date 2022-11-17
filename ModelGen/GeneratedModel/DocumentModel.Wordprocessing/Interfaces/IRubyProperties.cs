namespace DocumentModel.Wordprocessing;

public interface IRubyProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IRubyAlign? RubyAlign { get ; set; }
  
  public IPhoneticGuideTextFontSize? PhoneticGuideTextFontSize { get ; set; }
  
  public IPhoneticGuideRaise? PhoneticGuideRaise { get ; set; }
  
  public IPhoneticGuideBaseTextSize? PhoneticGuideBaseTextSize { get ; set; }
  
  public ILanguageId? LanguageId { get ; set; }
  
  public IDirty? Dirty { get ; set; }
  
}
