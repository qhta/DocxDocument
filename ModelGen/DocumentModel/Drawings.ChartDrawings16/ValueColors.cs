namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ValueColors Class.
/// </summary>
public partial class ValueColors: ModelElement<DXO16DCD.ValueColors>
{
  public ValueColors(): base(){ }
  
  public ValueColors(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueColors(DXO16DCD.ValueColors openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   MinColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MinColorSolidColorFillProperties? MinColorSolidColorFillProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.MinColorSolidColorFillProperties,DXO16DCD.MinColorSolidColorFillProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MinColorSolidColorFillProperties,DXO16DCD.MinColorSolidColorFillProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   MidColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MidColorSolidColorFillProperties? MidColorSolidColorFillProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.MidColorSolidColorFillProperties,DXO16DCD.MidColorSolidColorFillProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MidColorSolidColorFillProperties,DXO16DCD.MidColorSolidColorFillProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   MaxColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.MaxColorSolidColorFillProperties,DXO16DCD.MaxColorSolidColorFillProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MaxColorSolidColorFillProperties,DXO16DCD.MaxColorSolidColorFillProperties>(value);
    }
  }
  
}
