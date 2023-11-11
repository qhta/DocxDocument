namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ColorMappingType Class.
/// </summary>
public partial class ColorMappingType: ModelElement<DXD.ColorMappingType>
{
  public ColorMappingType(): base(){ }
  
  public ColorMappingType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMappingType(DXD.ColorMappingType openXmlElement): base(openXmlElement) { }
  
  
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
