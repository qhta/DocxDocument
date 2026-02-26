namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Styles
{
  public bool ShouldSerializeDocDefaults() => !DocDefaults.IsEmpty();

  public bool ShouldSerializeLatentStyles() => LatentStyles.Count > 0;

  public bool ShouldSerializeDefinedStyles() => DefinedStyles.Count > 0;

}
