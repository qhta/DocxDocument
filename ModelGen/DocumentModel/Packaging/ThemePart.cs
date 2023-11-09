namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ThemePart
/// </summary>
public partial class ThemePart: ModelPartElement<DXPack.ThemePart>
{
  public ThemePart(): base(){ }
  
  public ThemePart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public ThemePart(DXPack.ThemePart openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public String? ContentType
  {
    get
    {
      return _Element?.ContentType;
    }
    set
    {
      _ExistingElement.ContentType = value;
    }
  }
  
  [DataMember]
  public String? RelationshipType
  {
    get
    {
      return _Element?.RelationshipType;
    }
    set
    {
      _ExistingElement.RelationshipType = value;
    }
  }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMD.Theme? Theme
  {
    get
    {
        return ThemeConverter.CreateModelElement(_Element?.RootElement as DXD.Theme);
    }
    set
    {
      if (value != null)
      {
         var rootElement = ThemeConverter.CreateOpenXmlElement<DXD.Theme>(value);
         if (rootElement != null)
           _ExistingElement.Theme = rootElement;
      }
    }
  }
  
}
