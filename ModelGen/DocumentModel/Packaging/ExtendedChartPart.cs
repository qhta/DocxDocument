namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ExtendedChartPart
/// </summary>
public partial class ExtendedChartPart: ModelElement<DXPack.ExtendedChartPart>
{
  public ExtendedChartPart(): base(){ }
  
  public ExtendedChartPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExtendedChartPart(DXPack.ExtendedChartPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMDCD16.ChartSpace? ChartSpace
  {
    get
    {
        return ChartSpaceConverter.CreateModelElement(_Element?.RootElement as DXO16DCD.ChartSpace);
    }
    set
    {
      if (value != null)
      {
         var rootElement = ChartSpaceConverter.CreateOpenXmlElement<DXO16DCD.ChartSpace>(value);
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
