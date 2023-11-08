namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the Layout Class.
/// </summary>
public partial class Layout: ModelElement<DXO13DC.Layout>
{
  public Layout(): base(){ }
  
  public Layout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Layout(DXO13DC.Layout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Manual Layout.
  /// </summary>
  [DataMember]
  public DMDC.ManualLayout? ManualLayout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ManualLayout>();
      if (element != null)
        return ManualLayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ManualLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ManualLayoutConverter.CreateOpenXmlElement<DXDC.ManualLayout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
