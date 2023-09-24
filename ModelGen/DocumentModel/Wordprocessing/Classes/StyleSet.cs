namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a reference to a set of character forms defined within the font to be used as a stylistic set. For more information about stylistic sets, see OpenType.
/// </summary>
public partial class StyleSet
{
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? Id { get; set; }
  
  
  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffKind? Val { get; set; }
  
}
