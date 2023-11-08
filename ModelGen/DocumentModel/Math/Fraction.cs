namespace DocumentModel.Math;


/// <summary>
///   Fraction Function.
/// </summary>
public partial class Fraction: ModelElement<DXM.Fraction>
{
  public Fraction(): base(){ }
  
  public Fraction(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Fraction(DXM.Fraction openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Fraction Properties.
  /// </summary>
  [DataMember]
  public DMM.FractionProperties? FractionProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.FractionProperties>();
      if (element != null)
        return FractionPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.FractionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FractionPropertiesConverter.CreateOpenXmlElement<DXM.FractionProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Numerator.
  /// </summary>
  [DataMember]
  public DMM.Numerator? Numerator
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Numerator>();
      if (element != null)
        return NumeratorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Numerator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumeratorConverter.CreateOpenXmlElement<DXM.Numerator>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Denominator.
  /// </summary>
  [DataMember]
  public DMM.Denominator? Denominator
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Denominator>();
      if (element != null)
        return DenominatorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Denominator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DenominatorConverter.CreateOpenXmlElement<DXM.Denominator>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
