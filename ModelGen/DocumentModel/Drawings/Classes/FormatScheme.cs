namespace DocumentModel.Drawings;


/// <summary>
///   This element contains the background fill styles, effect styles, fill styles, and line styles which define the style matrix for a theme.  The style matrix consists of subtle, moderate, and intense fills, lines, and effects.  The background fills are not generally thought of to directly be associated with the matrix, but do play a role in the style of the overall document.  Usually, a given object chooses a single line style, a single fill style, and a single effect style in order to define the overall final look of the object.
/// </summary>
public partial class FormatScheme
{
  
  /// <summary>
  ///   Defines the name for the format scheme.  The name is simply a human readable string which identifies the format scheme in the user interface.
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Fill Style List.
  /// </summary>
  public FillStyleList? FillStyleList { get; set; }
  
  
  /// <summary>
  ///   Line Style List.
  /// </summary>
  public LineStyleList? LineStyleList { get; set; }
  
  
  /// <summary>
  ///   Effect Style List.
  /// </summary>
  public EffectStyleList? EffectStyleList { get; set; }
  
  
  /// <summary>
  ///   Background Fill Style List.
  /// </summary>
  public BackgroundFillStyleList? BackgroundFillStyleList { get; set; }
  
}
