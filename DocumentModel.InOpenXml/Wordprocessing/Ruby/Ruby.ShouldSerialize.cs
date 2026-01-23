namespace DocumentModel.Wordprocessing;

public partial class Ruby
{
  public bool ShouldSerializeRubyProperties() => RubyProperties is not null;
  public bool ShouldSerializeRubyContent() => RubyContent is not null;
  public bool ShouldSerializeRubyBase() => RubyBase is not null;
}
