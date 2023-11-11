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
      return _Element?.GetObject<DMVML.ShapeIdMap,DXVO.ShapeIdMap>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.ShapeIdMap,DXVO.ShapeIdMap>(value);
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
      return _Element?.GetObject<DMVML.RegroupTable,DXVO.RegroupTable>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.RegroupTable,DXVO.RegroupTable>(value);
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
      return _Element?.GetObject<DMVML.Rules,DXVO.Rules>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Rules,DXVO.Rules>(value);
    }
  }
  
}
