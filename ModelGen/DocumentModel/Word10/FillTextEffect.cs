namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the fill for text. By default, this element is absent. When this element is absent, the color of text is determined by the color element.
/// </summary>
public partial class FillTextEffect: ModelElement<DXO10W.FillTextEffect>
{
  public FillTextEffect(): base(){ }
  
  public FillTextEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillTextEffect(DXO10W.FillTextEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NoFillEmpty.
  /// </summary>
  [DataMember]
  public DMW10.NoFillEmpty? NoFillEmpty
  {
    get
    {
      return _Element?.GetObject<DMW10.NoFillEmpty,DXO10W.NoFillEmpty>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.NoFillEmpty,DXO10W.NoFillEmpty>(value);
    }
  }
  
  
  /// <summary>
  ///   SolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMW10.SolidColorFillProperties? SolidColorFillProperties
  {
    get
    {
      return _Element?.GetObject<DMW10.SolidColorFillProperties,DXO10W.SolidColorFillProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.SolidColorFillProperties,DXO10W.SolidColorFillProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   GradientFillProperties.
  /// </summary>
  [DataMember]
  public DMW10.GradientFillProperties? GradientFillProperties
  {
    get
    {
      return _Element?.GetObject<DMW10.GradientFillProperties,DXO10W.GradientFillProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.GradientFillProperties,DXO10W.GradientFillProperties>(value);
    }
  }
  
}
