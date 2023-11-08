namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ColorMapOverride Class.
/// </summary>
public partial class ColorMapOverride: ModelElement<DXDC.ColorMapOverride>
{
  public ColorMapOverride(): base(){ }
  
  public ColorMapOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMapOverride(DXDC.ColorMapOverride openXmlElement): base(openXmlElement) { }
  
  
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
