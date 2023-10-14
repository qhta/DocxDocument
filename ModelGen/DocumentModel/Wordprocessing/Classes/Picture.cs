namespace DocumentModel.Wordprocessing;


/// <summary>
///   VML Object.
/// </summary>
public partial class Picture
{
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.HexBinary? AnchorId { get; set; }
  
  public DocumentModel.Wordprocessing.MovieReference? MovieReference { get; set; }
  
  public DocumentModel.Wordprocessing.Control? Control { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
