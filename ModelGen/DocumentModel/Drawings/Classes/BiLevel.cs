namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a bi-level (black/white) effect. Input colors whose luminance is less than the specified threshold value are changed to black. Input colors whose luminance are greater than or equal the specified value are set to white. The alpha effect values are unaffected by this effect.
/// </summary>
public partial class BiLevel
{
  
  /// <summary>
  ///   Specifies the luminance threshold for the Bi-Level effect. Values greater than or equal to the threshold are set to white. Values lesser than the threshold are set to black.
  /// </summary>
  public Int32? Threshold { get; set; }
  
}
