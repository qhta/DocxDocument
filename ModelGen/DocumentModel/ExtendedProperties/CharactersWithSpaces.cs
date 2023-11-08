namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Number of Characters (With Spaces).
/// </summary>
public partial class CharactersWithSpaces: ModelElement<DXEP.CharactersWithSpaces>
{
  public CharactersWithSpaces(): base(){ }
  
  public CharactersWithSpaces(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CharactersWithSpaces(DXEP.CharactersWithSpaces openXmlElement): base(openXmlElement) { }
  
}
