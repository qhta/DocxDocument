namespace DocumentModel.Math;


/// <summary>
///   Sub-Superscript Function.
/// </summary>
public partial class SubSuperscript: ModelElement<DXM.SubSuperscript>
{
  public SubSuperscript(): base(){ }
  
  public SubSuperscript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubSuperscript(DXM.SubSuperscript openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Sub-Superscript Properties.
  /// </summary>
  [DataMember]
  public DMM.SubSuperscriptProperties? SubSuperscriptProperties
  {
    get
    {
      return _Element?.GetObject<DMM.SubSuperscriptProperties,DXM.SubSuperscriptProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SubSuperscriptProperties,DXM.SubSuperscriptProperties>(value);
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
  ///   Subscript (Sub-Superscript).
  /// </summary>
  [DataMember]
  public DMM.SubArgument? SubArgument
  {
    get
    {
      return _Element?.GetObject<DMM.SubArgument,DXM.SubArgument>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SubArgument,DXM.SubArgument>(value);
    }
  }
  
  
  /// <summary>
  ///   Superscript (Sub-Superscript function).
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
