namespace DocumentModel.Wordprocessing;

public partial class RubyElement
{
  public bool ShouldSerializeRuby() => Ruby == true;
}
