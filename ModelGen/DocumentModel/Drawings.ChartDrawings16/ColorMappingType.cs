namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ColorMappingType Class.
/// </summary>
public partial class ColorMappingType: ModelElement<DXO16DCD.ColorMappingType>
{
  public ColorMappingType(): base(){ }
  
  public ColorMappingType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMappingType(DXO16DCD.ColorMappingType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
