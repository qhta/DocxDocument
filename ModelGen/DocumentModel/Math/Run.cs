namespace DocumentModel.Math;


/// <summary>
///   Defines the Run Class.
/// </summary>
public partial class Run: ModelElement<DXM.Run>
{
  public Run(): base(){ }
  
  public Run(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Run(DXM.Run openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [DataMember]
  public DMM.RunProperties? MathRunProperties
  {
    get
    {
      return _Element?.GetObject<DMM.RunProperties,DXM.RunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.RunProperties,DXM.RunProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get
    {
      return _Element?.GetObject<DMW.RunProperties,DXW.RunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunProperties,DXW.RunProperties>(value);
    }
  }
  
}
