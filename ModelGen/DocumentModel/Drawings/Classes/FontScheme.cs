namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the font scheme within the theme.  The font scheme consists of a pair of major and minor fonts for which to use in a document.  The major font corresponds well with the heading areas of a document, and the minor font corresponds well with the normal text or paragraph areas.
/// </summary>
public partial class FontScheme
{
  
  /// <summary>
  ///   The name of the font scheme shown in the user interface.
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Major Font.
  /// </summary>
  public MajorFont? MajorFont { get; set; }
  
  
  /// <summary>
  ///   Minor fonts.
  /// </summary>
  public MinorFont? MinorFont { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
  
}
