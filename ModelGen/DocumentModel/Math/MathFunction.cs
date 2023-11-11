namespace DocumentModel.Math;


/// <summary>
///   Function Apply Function.
/// </summary>
public partial class MathFunction: ModelElement<DXM.MathFunction>
{
  public MathFunction(): base(){ }
  
  public MathFunction(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MathFunction(DXM.MathFunction openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Function Properties.
  /// </summary>
  [DataMember]
  public DMM.FunctionProperties? FunctionProperties
  {
    get
    {
      return _Element?.GetObject<DMM.FunctionProperties,DXM.FunctionProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.FunctionProperties,DXM.FunctionProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Function Name.
  /// </summary>
  [DataMember]
  public DMM.FunctionName? FunctionName
  {
    get
    {
      return _Element?.GetObject<DMM.FunctionName,DXM.FunctionName>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.FunctionName,DXM.FunctionName>(value);
    }
  }
  
  
  /// <summary>
  ///   Base (Argument).
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get
    {
      return _Element?.GetObject<DMM.Base,DXM.Base>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Base,DXM.Base>(value);
    }
  }
  
}
