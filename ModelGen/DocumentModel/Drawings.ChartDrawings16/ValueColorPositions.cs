namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ValueColorPositions Class.
/// </summary>
public partial class ValueColorPositions: ModelElement<DXO16DCD.ValueColorPositions>
{
  public ValueColorPositions(): base(){ }
  
  public ValueColorPositions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueColorPositions(DXO16DCD.ValueColorPositions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   count, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Int32? Count
  {
    get
    {
      return _Element?.Count?.Value;
    }
    set
    {
      _ExistingElement.Count = value;
    }
  }
  
  
  /// <summary>
  ///   MinValueColorEndPosition.
  /// </summary>
  [DataMember]
  public DMDCD16.MinValueColorEndPosition? MinValueColorEndPosition
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MinValueColorEndPosition>();
      if (element != null)
        return MinValueColorEndPositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MinValueColorEndPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinValueColorEndPositionConverter.CreateOpenXmlElement<DXO16DCD.MinValueColorEndPosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ValueColorMiddlePosition.
  /// </summary>
  [DataMember]
  public DMDCD16.ValueColorMiddlePosition? ValueColorMiddlePosition
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ValueColorMiddlePosition>();
      if (element != null)
        return ValueColorMiddlePositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ValueColorMiddlePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueColorMiddlePositionConverter.CreateOpenXmlElement<DXO16DCD.ValueColorMiddlePosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   MaxValueColorEndPosition.
  /// </summary>
  [DataMember]
  public DMDCD16.MaxValueColorEndPosition? MaxValueColorEndPosition
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MaxValueColorEndPosition>();
      if (element != null)
        return MaxValueColorEndPositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MaxValueColorEndPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MaxValueColorEndPositionConverter.CreateOpenXmlElement<DXO16DCD.MaxValueColorEndPosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
