namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Protection Class.
/// </summary>
public partial class Protection: ModelElement<DXDC.Protection>
{
  public Protection(): base(){ }
  
  public Protection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Protection(DXDC.Protection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Chart Object.
  /// </summary>
  [DataMember]
  public DMDC.ChartObject? ChartObject
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartObject,DXDC.ChartObject>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartObject,DXDC.ChartObject>(value);
    }
  }
  
  
  /// <summary>
  ///   Data Cannot Be Changed.
  /// </summary>
  [DataMember]
  public DMDC.Data? Data
  {
    get
    {
      return _Element?.GetObject<DMDC.Data,DXDC.Data>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Data,DXDC.Data>(value);
    }
  }
  
  
  /// <summary>
  ///   Formatting.
  /// </summary>
  [DataMember]
  public DMDC.Formatting? Formatting
  {
    get
    {
      return _Element?.GetObject<DMDC.Formatting,DXDC.Formatting>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Formatting,DXDC.Formatting>(value);
    }
  }
  
  
  /// <summary>
  ///   Selection.
  /// </summary>
  [DataMember]
  public DMDC.Selection? Selection
  {
    get
    {
      return _Element?.GetObject<DMDC.Selection,DXDC.Selection>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Selection,DXDC.Selection>(value);
    }
  }
  
  
  /// <summary>
  ///   User Interface.
  /// </summary>
  [DataMember]
  public DMDC.UserInterface? UserInterface
  {
    get
    {
      return _Element?.GetObject<DMDC.UserInterface,DXDC.UserInterface>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.UserInterface,DXDC.UserInterface>(value);
    }
  }
  
}
