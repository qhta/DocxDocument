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
      return _Element?.GetObject<DMDCD16.MinValueColorEndPosition,DXO16DCD.MinValueColorEndPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MinValueColorEndPosition,DXO16DCD.MinValueColorEndPosition>(value);
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
      return _Element?.GetObject<DMDCD16.ValueColorMiddlePosition,DXO16DCD.ValueColorMiddlePosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ValueColorMiddlePosition,DXO16DCD.ValueColorMiddlePosition>(value);
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
      return _Element?.GetObject<DMDCD16.MaxValueColorEndPosition,DXO16DCD.MaxValueColorEndPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MaxValueColorEndPosition,DXO16DCD.MaxValueColorEndPosition>(value);
    }
  }
  
}
