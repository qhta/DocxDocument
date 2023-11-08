namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UpDownBarType Class.
/// </summary>
public partial class UpDownBarType: ModelElement<DXDC.UpDownBarType>
{
  public UpDownBarType(): base(){ }
  
  public UpDownBarType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpDownBarType(DXDC.UpDownBarType openXmlElement): base(openXmlElement) { }
  
  
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
