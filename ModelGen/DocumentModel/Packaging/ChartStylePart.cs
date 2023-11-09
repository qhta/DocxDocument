namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ChartStylePart
/// </summary>
public partial class ChartStylePart: ModelPartElement<DXPack.ChartStylePart>
{
  public ChartStylePart(): base(){ }
  
  public ChartStylePart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public ChartStylePart(DXPack.ChartStylePart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMDCS.ChartStyle? ChartStyle
  {
    get
    {
        return ChartStyleConverter.CreateModelElement(_Element?.RootElement as DXO13DCS.ChartStyle);
    }
    set
    {
      if (value != null)
      {
         var rootElement = ChartStyleConverter.CreateOpenXmlElement<DXO13DCS.ChartStyle>(value);
         if (rootElement != null)
           _ExistingElement.ChartStyle = rootElement;
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
