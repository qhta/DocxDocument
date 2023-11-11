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
      return _Element?.GetObject<DMM.FractionProperties,DXM.FractionProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.FractionProperties,DXM.FractionProperties>(value);
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
      return _Element?.GetObject<DMM.Numerator,DXM.Numerator>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Numerator,DXM.Numerator>(value);
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
      return _Element?.GetObject<DMM.Denominator,DXM.Denominator>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Denominator,DXM.Denominator>(value);
    }
  }
  
}
