namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the LeaderLines Class.
/// </summary>
public partial class LeaderLines: ModelElement<DXO13DC.LeaderLines>
{
  public LeaderLines(): base(){ }
  
  public LeaderLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LeaderLines(DXO13DC.LeaderLines openXmlElement): base(openXmlElement) { }
  
  
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
