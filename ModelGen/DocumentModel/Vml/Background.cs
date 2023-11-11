namespace DocumentModel.Vml;


/// <summary>
///   Document Background.
/// </summary>
public partial class Background: ModelElement<DXV.Background>
{
  public Background(): base(){ }
  
  public Background(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Background(DXV.Background openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [DataMember]
  public Boolean? Filled
  {
    get
    {
      return _Element?.Filled?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Filled = value;
      else
        _ExistingElement.Filled = null;
    }
  }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  [DataMember]
  public String? Fillcolor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Fillcolor);
    }
    set
    {
      _ExistingElement.Fillcolor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Fill.
  /// </summary>
  [DataMember]
  public DMVML.Fill? Fill
  {
    get
    {
      return _Element?.GetObject<DMVML.Fill,DXV.Fill>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Fill,DXV.Fill>(value);
    }
  }
  
}
