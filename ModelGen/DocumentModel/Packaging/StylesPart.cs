namespace DocumentModel.Packaging;


/// <summary>
///   Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public partial class StylesPart: ModelElement<DXPack.StylesPart>
{
  public StylesPart(): base(){ }
  
  public StylesPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StylesPart(DXPack.StylesPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMW.Styles? Styles
  {
    get
    {
        return StylesConverter.CreateModelElement(_Element?.RootElement as DXW.Styles);
    }
    set
    {
      if (value != null)
      {
         var rootElement = StylesConverter.CreateOpenXmlElement<DXW.Styles>(value);
         if (rootElement != null)
           _ExistingElement.Styles = rootElement;
      }
    }
  }
  
}
