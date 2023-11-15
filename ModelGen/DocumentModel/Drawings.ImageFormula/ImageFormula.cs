namespace DocumentModel.Drawings.ImageFormula;


/// <summary>
///   Defines the ImageFormula Class.
/// </summary>
public partial class ImageFormula: ModelElement<DXOD22IF.ImageFormula>
{
  public ImageFormula(): base(){ }
  
  public ImageFormula(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImageFormula(DXOD22IF.ImageFormula openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   formula, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? Formula
  {
    get => _Element?.Formula;
    set => _ExistingElement.Formula = value;
  }
  
}
