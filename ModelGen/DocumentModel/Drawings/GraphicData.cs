namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the reference to a graphic object within the document. This graphic object is provided entirely by the document authors who choose to persist this data within the document.
/// </summary>
public partial class GraphicData: ModelElement<DXD.GraphicData>
{
  public GraphicData(): base(){ }
  
  public GraphicData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GraphicData(DXD.GraphicData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
}
