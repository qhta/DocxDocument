namespace DocumentModel.Wordprocessing;


/// <summary>
///   VML Object.
/// </summary>
public partial class Picture
{
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? AnchorId { get; set; }
  
  public RelationshipType? MovieReference { get; set; }
  
  public Control? Control { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
