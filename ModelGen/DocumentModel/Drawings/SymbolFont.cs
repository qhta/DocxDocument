namespace DocumentModel.Drawings;


/// <summary>
///   Defines the SymbolFont Class.
/// </summary>
public partial class SymbolFont: ModelElement<DXD.SymbolFont>
{
  public SymbolFont(): base(){ }
  
  public SymbolFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SymbolFont(DXD.SymbolFont openXmlElement): base(openXmlElement) { }
  
}
