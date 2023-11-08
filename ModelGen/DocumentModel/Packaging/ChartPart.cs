namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ChartPart
/// </summary>
public partial class ChartPart: ModelElement<DXPack.ChartPart>
{
  public ChartPart(): base(){ }
  
  public ChartPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartPart(DXPack.ChartPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMDC.ChartSpace? ChartSpace
  {
    get
    {
        return ChartSpaceConverter.CreateModelElement(_Element?.RootElement as DXDC.ChartSpace);
    }
    set
    {
      if (value != null)
      {
         var rootElement = ChartSpaceConverter.CreateOpenXmlElement<DXDC.ChartSpace>(value);
         if (rootElement != null)
           _ExistingElement.ChartSpace = rootElement;
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
