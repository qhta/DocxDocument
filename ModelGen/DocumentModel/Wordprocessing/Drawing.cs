namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that a DrawingML object is located at this position in the run’s contents. The layout properties of this DrawingML object are specified using the WordprocessingML Drawing syntax (§20.4).
/// </summary>
public partial class Drawing
{
  
  /// <summary>
  ///   Drawing Element Anchor.
  /// </summary>
  public DMDW.Anchor? Anchor { get; set; }
  
  
  /// <summary>
  ///   Inline Drawing Object.
  /// </summary>
  public DMDW.Inline? Inline { get; set; }
  
}
