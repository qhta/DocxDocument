namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ThemeOverridePart
/// </summary>
public partial class ThemeOverridePart: ModelElement<DXPack.ThemeOverridePart>
{
  public ThemeOverridePart(): base(){ }
  
  public ThemeOverridePart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeOverridePart(DXPack.ThemeOverridePart openXmlElement): base(openXmlElement) { }
  
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
  public DMD.ThemeOverride? ThemeOverride
  {
    get
    {
        return ThemeOverrideConverter.CreateModelElement(_Element?.RootElement as DXD.ThemeOverride);
    }
    set
    {
      if (value != null)
      {
         var rootElement = ThemeOverrideConverter.CreateOpenXmlElement<DXD.ThemeOverride>(value);
         if (rootElement != null)
           _ExistingElement.ThemeOverride = rootElement;
      }
    }
  }
  
}
