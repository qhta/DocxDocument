namespace DocumentModel.Vml;


/// <summary>
///   Most Recently Used Colors.
/// </summary>
public partial class ColorMostRecentlyUsed: ModelElement<DXVO.ColorMostRecentlyUsed>
{
  public ColorMostRecentlyUsed(): base(){ }
  
  public ColorMostRecentlyUsed(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMostRecentlyUsed(DXVO.ColorMostRecentlyUsed openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Recent colors
  /// </summary>
  [DataMember]
  public String? Colors
  {
    get => _Element?.Colors;
    set => _ExistingElement.Colors = value;
  }
  
}
