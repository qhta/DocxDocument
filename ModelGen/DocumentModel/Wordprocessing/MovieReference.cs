namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a location within a document where the specified parent image shall be treated as a static placeholder for an embedded movie. The specified movie file's contents should be displayed when requested at this location in the document. The location of the embedded movie to be displayed when supported shall be specified by the relationship whose Id attribute matches the id attribute on this element.
/// </summary>
public partial class MovieReference: ModelElement<DXW.MovieReference>
{
  public MovieReference(): base(){ }
  
  public MovieReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MovieReference(DXW.MovieReference openXmlElement): base(openXmlElement) { }
  
}
