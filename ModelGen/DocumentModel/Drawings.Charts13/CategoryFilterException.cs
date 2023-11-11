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
      return _Element?.GetObject<DMDC13.SequenceOfReferences,DXO13DC.SequenceOfReferences>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.SequenceOfReferences,DXO13DC.SequenceOfReferences>(value);
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
      return _Element?.GetObject<DMDC13.ShapeProperties,DXO13DC.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.ShapeProperties,DXO13DC.ShapeProperties>(value);
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
      SimpleValueConverter.SetValue<DXO13DC.Explosion,System.UInt32>(_ExistingElement, value);
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
      return _Element?.GetObject<DMDC13.InvertIfNegativeBoolean,DXO13DC.InvertIfNegativeBoolean>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.InvertIfNegativeBoolean,DXO13DC.InvertIfNegativeBoolean>(value);
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
      return _Element?.GetObject<DMDC13.Bubble3D,DXO13DC.Bubble3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.Bubble3D,DXO13DC.Bubble3D>(value);
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
      return _Element?.GetObject<DMDC13.Marker,DXO13DC.Marker>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.Marker,DXO13DC.Marker>(value);
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
      return _Element?.GetObject<DMDC13.DataLabel,DXO13DC.DataLabel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.DataLabel,DXO13DC.DataLabel>(value);
    }
  }
  
}
