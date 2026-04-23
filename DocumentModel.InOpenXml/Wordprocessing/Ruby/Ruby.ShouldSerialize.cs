namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Ruby
{
  public bool ShouldSerializeRubyProperties() => RubyProperties is not null && ShouldSerialize(RubyProperties);
  public bool ShouldSerializeRubyContent() => RubyContent is not null && ShouldSerialize(RubyContent);
  public bool ShouldSerializeRubyBase() => RubyBase is not null && ShouldSerialize(RubyBase);
}
