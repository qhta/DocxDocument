namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the reference to a graphic object within the document. This graphic object is provided entirely by the document authors who choose to persist this data within the document.
/// </summary>
public partial class GraphicData
{
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  public String? Uri { get; set; }
  
}
