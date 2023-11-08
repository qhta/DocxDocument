namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DataPoint Class.
/// </summary>
public partial class DataPoint: ModelElement<DXDC.DataPoint>
{
  public DataPoint(): base(){ }
  
  public DataPoint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataPoint(DXDC.DataPoint openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index.
  /// </summary>
  [DataMember]
  public DMDC.Index? Index
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Index>();
      if (element != null)
        return IndexConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Index>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IndexConverter.CreateOpenXmlElement<DXDC.Index>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Invert if Negative.
  /// </summary>
  [DataMember]
  public DMDC.InvertIfNegative? InvertIfNegative
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.InvertIfNegative>();
      if (element != null)
        return InvertIfNegativeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.InvertIfNegative>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InvertIfNegativeConverter.CreateOpenXmlElement<DXDC.InvertIfNegative>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  [DataMember]
  public DMDC.Marker? Marker
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Marker>();
      if (element != null)
        return MarkerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Marker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkerConverter.CreateOpenXmlElement<DXDC.Marker>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   3D Bubble.
  /// </summary>
  [DataMember]
  public DMDC.Bubble3D? Bubble3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Bubble3D>();
      if (element != null)
        return Bubble3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Bubble3DConverter.CreateOpenXmlElement<DXDC.Bubble3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Explosion.
  /// </summary>
  [DataMember]
  public DMDC.Explosion? Explosion
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Explosion>();
      if (element != null)
        return ExplosionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Explosion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExplosionConverter.CreateOpenXmlElement<DXDC.Explosion>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
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
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  [DataMember]
  public DMDC.PictureOptions? PictureOptions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PictureOptions>();
      if (element != null)
        return PictureOptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PictureOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureOptionsConverter.CreateOpenXmlElement<DXDC.PictureOptions>(value);
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
