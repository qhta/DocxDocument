namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a font within the styles area of DrawingML.  A font is defined by a script along with a typeface.
/// </summary>
public partial class SupplementalFont
{
  
  /// <summary>
  ///   Specifies the script, or language, in which the typeface is supposed to be used.
  /// </summary>
  [SchemaAttr("script")]
  public String? Script { get; set; }
  
  
  /// <summary>
  ///   Specifies the font face to use.
  /// </summary>
  [SchemaAttr("typeface")]
  public String? Typeface { get; set; }
  
}
