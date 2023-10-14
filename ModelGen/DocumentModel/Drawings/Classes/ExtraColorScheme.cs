namespace DocumentModel.Drawings;


/// <summary>
///   This element defines an auxiliary color scheme, which includes both a color scheme and color mapping.  This is mainly used for backward compatibility concerns and roundtrips information required by earlier versions.
/// </summary>
public partial class ExtraColorScheme
{
  
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme { get; set; }
  
  
  /// <summary>
  ///   ColorMap.
  /// </summary>
  public DocumentModel.Drawings.ColorMap? ColorMap { get; set; }
  
}
