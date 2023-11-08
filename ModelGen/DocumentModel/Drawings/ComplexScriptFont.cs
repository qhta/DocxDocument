namespace DocumentModel.Drawings;


/// <summary>
///   Complex Script Font.
/// </summary>
public partial class ComplexScriptFont: ModelElement<DXD.ComplexScriptFont>
{
  public ComplexScriptFont(): base(){ }
  
  public ComplexScriptFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ComplexScriptFont(DXD.ComplexScriptFont openXmlElement): base(openXmlElement) { }
  
}
