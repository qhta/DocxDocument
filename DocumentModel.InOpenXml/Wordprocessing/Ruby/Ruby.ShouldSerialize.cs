namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Ruby
{
  public bool ShouldSerializeRubyProperties() => RubyProperties is not null;
  public bool ShouldSerializeRubyContent() => RubyContent is not null;
  public bool ShouldSerializeRubyBase() => RubyBase is not null;
}
