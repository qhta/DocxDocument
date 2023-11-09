namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ChartColorStylePart
/// </summary>
public partial class ChartColorStylePart: ModelPartElement<DXPack.ChartColorStylePart>
{
  public ChartColorStylePart(): base(){ }
  
  public ChartColorStylePart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public ChartColorStylePart(DXPack.ChartColorStylePart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMDCS.ColorStyle? ColorStyle
  {
    get
    {
        return ColorStyleConverter.CreateModelElement(_Element?.RootElement as DXO13DCS.ColorStyle);
    }
    set
    {
      if (value != null)
      {
         var rootElement = ColorStyleConverter.CreateOpenXmlElement<DXO13DCS.ColorStyle>(value);
         if (rootElement != null)
           _ExistingElement.ColorStyle = rootElement;
      }
    }
  }
  
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
  
}
