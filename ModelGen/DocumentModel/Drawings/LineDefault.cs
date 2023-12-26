namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a default line that is used within a document.
/// </summary>
public partial class LineDefault: ModelElement<DXD.LineDefault>
{
  public LineDefault(): base(){ }
  
  public LineDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineDefault(DXD.LineDefault openXmlElement): base(openXmlElement) { }
  
}
