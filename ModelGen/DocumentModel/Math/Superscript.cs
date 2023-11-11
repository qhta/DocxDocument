namespace DocumentModel.Math;


/// <summary>
///   Superscript Function.
/// </summary>
public partial class Superscript: ModelElement<DXM.Superscript>
{
  public Superscript(): base(){ }
  
  public Superscript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Superscript(DXM.Superscript openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Superscript Properties.
  /// </summary>
  [DataMember]
  public DMM.SuperscriptProperties? SuperscriptProperties
  {
    get
    {
      return _Element?.GetObject<DMM.SuperscriptProperties,DXM.SuperscriptProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SuperscriptProperties,DXM.SuperscriptProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Base.
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
  
  
  /// <summary>
  ///   Superscript (Superscript function).
  /// </summary>
  [DataMember]
  public DMM.SuperArgument? SuperArgument
  {
    get
    {
      return _Element?.GetObject<DMM.SuperArgument,DXM.SuperArgument>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SuperArgument,DXM.SuperArgument>(value);
    }
  }
  
}
