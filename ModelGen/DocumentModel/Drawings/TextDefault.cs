namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the default formatting which is applied to text in a document by default.  The default formatting can and should be applied to the shape when it is initially inserted into a document.
/// </summary>
public partial class TextDefault: ModelElement<DXD.TextDefault>
{
  public TextDefault(): base(){ }
  
  public TextDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextDefault(DXD.TextDefault openXmlElement): base(openXmlElement) { }
  
}
