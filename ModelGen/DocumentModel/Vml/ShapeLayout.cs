namespace DocumentModel.Vml;


/// <summary>
///   Shape Layout Properties.
/// </summary>
public partial class ShapeLayout: ModelElement<DXVO.ShapeLayout>
{
  public ShapeLayout(): base(){ }
  
  public ShapeLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeLayout(DXVO.ShapeLayout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape ID Map.
  /// </summary>
  [DataMember]
  public DMVML.ShapeIdMap? ShapeIdMap
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.ShapeIdMap>();
      if (element != null)
        return ShapeIdMapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.ShapeIdMap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeIdMapConverter.CreateOpenXmlElement<DXVO.ShapeIdMap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape Grouping History.
  /// </summary>
  [DataMember]
  public DMVML.RegroupTable? RegroupTable
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.RegroupTable>();
      if (element != null)
        return RegroupTableConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.RegroupTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RegroupTableConverter.CreateOpenXmlElement<DXVO.RegroupTable>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Rule Set.
  /// </summary>
  [DataMember]
  public DMVML.Rules? Rules
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.Rules>();
      if (element != null)
        return RulesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.Rules>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RulesConverter.CreateOpenXmlElement<DXVO.Rules>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
