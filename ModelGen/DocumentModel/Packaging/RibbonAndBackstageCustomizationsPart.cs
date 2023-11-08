namespace DocumentModel.Packaging;


/// <summary>
///   Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public partial class RibbonAndBackstageCustomizationsPart: ModelElement<DXPack.RibbonAndBackstageCustomizationsPart>
{
  public RibbonAndBackstageCustomizationsPart(): base(){ }
  
  public RibbonAndBackstageCustomizationsPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RibbonAndBackstageCustomizationsPart(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement): base(openXmlElement) { }
  
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
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMCUI10.CustomUI? CustomUI
  {
    get
    {
        return CustomUIConverter.CreateModelElement(_Element?.RootElement as DXO10CUI.CustomUI);
    }
    set
    {
      if (value != null)
      {
         var rootElement = CustomUIConverter.CreateOpenXmlElement<DXO10CUI.CustomUI>(value);
         if (rootElement != null)
           _ExistingElement.CustomUI = rootElement;
      }
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
  
}
