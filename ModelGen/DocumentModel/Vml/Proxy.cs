namespace DocumentModel.Vml;


/// <summary>
///   Shape Reference.
/// </summary>
public partial class Proxy: ModelElement<DXVO.Proxy>
{
  public Proxy(): base(){ }
  
  public Proxy(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Proxy(DXVO.Proxy openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Start Point Connection Flag
  /// </summary>
  [DataMember]
  public Boolean? Start
  {
    get
    {
      return _Element?.Start?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Start = value;
      else
        _ExistingElement.Start = null;
    }
  }
  
  
  /// <summary>
  ///   End Point Connection Flag
  /// </summary>
  [DataMember]
  public Boolean? End
  {
    get
    {
      return _Element?.End?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.End = value;
      else
        _ExistingElement.End = null;
    }
  }
  
  
  /// <summary>
  ///   Proxy Shape Reference
  /// </summary>
  [DataMember]
  public String? ShapeReference
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ShapeReference);
    }
    set
    {
      _ExistingElement.ShapeReference = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Connection Location
  /// </summary>
  [DataMember]
  public Int32? ConnectionLocation
  {
    get
    {
      return _Element?.ConnectionLocation?.Value;
    }
    set
    {
      _ExistingElement.ConnectionLocation = value;
    }
  }
  
}
