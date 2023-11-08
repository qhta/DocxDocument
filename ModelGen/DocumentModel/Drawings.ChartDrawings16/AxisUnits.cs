namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the AxisUnits Class.
/// </summary>
public partial class AxisUnits: ModelElement<DXO16DCD.AxisUnits>
{
  public AxisUnits(): base(){ }
  
  public AxisUnits(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AxisUnits(DXO16DCD.AxisUnits openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   AxisUnitsLabel.
  /// </summary>
  [DataMember]
  public DMDCD16.AxisUnitsLabel? AxisUnitsLabel
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.AxisUnitsLabel>();
      if (element != null)
        return AxisUnitsLabelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.AxisUnitsLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisUnitsLabelConverter.CreateOpenXmlElement<DXO16DCD.AxisUnitsLabel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
