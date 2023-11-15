namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Extension.
/// </summary>
public partial class Extension: ModelElement<DXDC.Extension>
{
  public Extension(): base(){ }
  
  public Extension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Extension(DXDC.Extension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Uniform Resource Identifier
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
}
