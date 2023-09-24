namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a list of stylistic sets that modify the display of OpenType fonts. (For more information about stylistic sets, see OpenType.) By default, there are no stylistic sets enabled.
/// </summary>
public partial class StylisticSets
{
  public ElementCollection<StyleSet>? Items { get; set; }
  
}
