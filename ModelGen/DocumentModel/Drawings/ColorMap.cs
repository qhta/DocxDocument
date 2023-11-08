namespace DocumentModel.Drawings;


/// <summary>
///   This element specifics the color mapping layer which allows a user to define colors for background and text.  This allows for swapping out of light/dark colors for backgrounds and the text on top of the background in order to maintain readability of the text  On a deeper level, this specifies exactly which colors the first 12 values refer to in the color scheme.
/// </summary>
public partial class ColorMap: ModelElement<DXD.ColorMap>
{
  public ColorMap(): base(){ }
  
  public ColorMap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMap(DXD.ColorMap openXmlElement): base(openXmlElement) { }
  
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
