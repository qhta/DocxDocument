namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
public partial class DiagramDefinitionExtension: ModelElement<DXDDD.DiagramDefinitionExtension>
{
  public DiagramDefinitionExtension(): base(){ }
  
  public DiagramDefinitionExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramDefinitionExtension(DXDDD.DiagramDefinitionExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDD1.NumberDiagramInfoList? NumberDiagramInfoList
  {
    get
    {
      return _Element?.GetObject<DMDD1.NumberDiagramInfoList,DXO19DD11.NumberDiagramInfoList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD1.NumberDiagramInfoList,DXO19DD11.NumberDiagramInfoList>(value);
    }
  }
  
  [DataMember]
  public DMDD2.TextListStyleType? TextListStyleType
  {
    get
    {
      return _Element?.GetObject<DMDD2.TextListStyleType,DXO19DD12.TextListStyleType>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD2.TextListStyleType,DXO19DD12.TextListStyleType>(value);
    }
  }
  
}
