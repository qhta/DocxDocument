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
  public DM.TrueFalseValue? Filled
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
      var element = _Element?.GetFirstChild<DXV.Fill>();
      if (element != null)
        return FillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXV.Fill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillConverter.CreateOpenXmlElement<DXV.Fill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
