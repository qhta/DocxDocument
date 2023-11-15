namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a font within the styles area of DrawingML.  A font is defined by a script along with a typeface.
/// </summary>
public partial class SupplementalFont: ModelElement<DXD.SupplementalFont>
{
  public SupplementalFont(): base(){ }
  
  public SupplementalFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SupplementalFont(DXD.SupplementalFont openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the script, or language, in which the typeface is supposed to be used.
  /// </summary>
  [DataMember]
  public String? Script
  {
    get => _Element?.Script;
    set => _ExistingElement.Script = value;
  }
  
  
  /// <summary>
  ///   Specifies the font face to use.
  /// </summary>
  [DataMember]
  public String? Typeface
  {
    get => _Element?.Typeface;
    set => _ExistingElement.Typeface = value;
  }
  
}
