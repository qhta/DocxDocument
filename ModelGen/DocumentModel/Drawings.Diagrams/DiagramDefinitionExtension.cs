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
      var element = _Element?.GetFirstChild<DXO19DD11.NumberDiagramInfoList>();
      if (element != null)
        return NumberDiagramInfoListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO19DD11.NumberDiagramInfoList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberDiagramInfoListConverter.CreateOpenXmlElement<DXO19DD11.NumberDiagramInfoList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDD2.TextListStyleType? TextListStyleType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO19DD12.TextListStyleType>();
      if (element != null)
        return TextListStyleTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO19DD12.TextListStyleType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextListStyleTypeConverter.CreateOpenXmlElement<DXO19DD12.TextListStyleType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
