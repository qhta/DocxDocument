namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ChartLinesType Class.
/// </summary>
public partial class ChartLinesType: ModelElement<DXDC.ChartLinesType>
{
  public ChartLinesType(): base(){ }
  
  public ChartLinesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartLinesType(DXDC.ChartLinesType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ChartShapeProperties>();
      if (element != null)
        return ChartShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
