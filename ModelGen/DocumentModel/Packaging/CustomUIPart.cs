namespace DocumentModel.Packaging;


/// <summary>
///   Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and QuickAccessToolbarCustomizationsPart.
/// </summary>
public partial class CustomUIPart: ModelPartElement<DXPack.CustomUIPart>
{
  public CustomUIPart(): base(){ }
  
  public CustomUIPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public CustomUIPart(DXPack.CustomUIPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMCUI.CustomUI? CustomUI
  {
    get
    {
        return CustomUIConverter.CreateModelElement(_Element?.RootElement as DXOCUI.CustomUI);
    }
    set
    {
      if (value != null)
      {
         var rootElement = CustomUIConverter.CreateOpenXmlElement<DXOCUI.CustomUI>(value);
         if (rootElement != null)
           _ExistingElement.CustomUI = rootElement;
      }
    }
  }
  
}
