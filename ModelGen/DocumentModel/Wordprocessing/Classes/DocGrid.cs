namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocGrid Class.
/// </summary>
public partial class DocGrid
{
  
  /// <summary>
  ///   Document Grid Type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.DocGridValues? Type { get; set; }
  
  
  /// <summary>
  ///   Document Grid Line Pitch
  /// </summary>
  [SchemaAttr("w:linePitch")]
  public Int32? LinePitch { get; set; }
  
  
  /// <summary>
  ///   Document Grid Character Pitch
  /// </summary>
  [SchemaAttr("w:charSpace")]
  public Int32? CharacterSpace { get; set; }
  
}
