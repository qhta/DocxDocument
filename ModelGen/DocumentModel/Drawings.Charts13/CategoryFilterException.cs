namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the CategoryFilterException Class.
/// </summary>
public partial class CategoryFilterException: ModelElement<DXO13DC.CategoryFilterException>
{
  public CategoryFilterException(): base(){ }
  
  public CategoryFilterException(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CategoryFilterException(DXO13DC.CategoryFilterException openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  [DataMember]
  public DMDC13.SequenceOfReferences? SequenceOfReferences
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.SequenceOfReferences>();
      if (element != null)
        return SequenceOfReferencesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.SequenceOfReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SequenceOfReferencesConverter.CreateOpenXmlElement<DXO13DC.SequenceOfReferences>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC13.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO13DC.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Explosion.
  /// </summary>
  [DataMember]
  public UInt32? Explosion
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO13DC.Explosion>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO13DC.Explosion,System.UInt32>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   InvertIfNegativeBoolean.
  /// </summary>
  [DataMember]
  public DMDC13.InvertIfNegativeBoolean? InvertIfNegativeBoolean
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.InvertIfNegativeBoolean>();
      if (element != null)
        return InvertIfNegativeBooleanConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.InvertIfNegativeBoolean>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InvertIfNegativeBooleanConverter.CreateOpenXmlElement<DXO13DC.InvertIfNegativeBoolean>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Bubble3D.
  /// </summary>
  [DataMember]
  public DMDC13.Bubble3D? Bubble3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.Bubble3D>();
      if (element != null)
        return Bubble3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Bubble3DConverter.CreateOpenXmlElement<DXO13DC.Bubble3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  [DataMember]
  public DMDC13.Marker? Marker
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.Marker>();
      if (element != null)
        return MarkerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.Marker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkerConverter.CreateOpenXmlElement<DXO13DC.Marker>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   DataLabel.
  /// </summary>
  [DataMember]
  public DMDC13.DataLabel? DataLabel
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.DataLabel>();
      if (element != null)
        return DataLabelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.DataLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelConverter.CreateOpenXmlElement<DXO13DC.DataLabel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
