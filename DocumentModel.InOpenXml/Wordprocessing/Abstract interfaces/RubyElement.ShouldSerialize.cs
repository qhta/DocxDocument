namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RubyElement
{
  public bool ShouldSerializeRuby() => Ruby == true;
}
