namespace DocumentModel.Packaging;


/// <summary>
///   Called from constructors of derived parts to initialize the IFixedContentTypePart interface. All derived parts must be parts that have fixed content type.
/// </summary>
public partial class IFixedContentTypePart: ModelElement<DXPack.IFixedContentTypePart>
{
  public IFixedContentTypePart(): base(){ }
  
  public IFixedContentTypePart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public IFixedContentTypePart(DXPack.IFixedContentTypePart openXmlElement): base(openXmlElement) { }
  
}
