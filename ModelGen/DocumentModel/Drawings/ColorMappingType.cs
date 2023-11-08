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
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
