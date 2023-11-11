namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the CustomUI Class.
/// </summary>
public partial class CustomUI: ModelElement<DXOCUI.CustomUI>
{
  public CustomUI(): base(){ }
  
  public CustomUI(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomUI(DXOCUI.CustomUI openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   onLoad
  /// </summary>
  [DataMember]
  public String? OnLoad
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OnLoad);
    }
    set
    {
      _ExistingElement.OnLoad = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   loadImage
  /// </summary>
  [DataMember]
  public String? LoadImage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LoadImage);
    }
    set
    {
      _ExistingElement.LoadImage = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   RepurposedCommands.
  /// </summary>
  [DataMember]
  public DMCUI.RepurposedCommands? RepurposedCommands
  {
    get
    {
      return _Element?.GetObject<DMCUI.RepurposedCommands,DXOCUI.RepurposedCommands>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.RepurposedCommands,DXOCUI.RepurposedCommands>(value);
    }
  }
  
  
  /// <summary>
  ///   Ribbon.
  /// </summary>
  [DataMember]
  public DMCUI.Ribbon? Ribbon
  {
    get
    {
      return _Element?.GetObject<DMCUI.Ribbon,DXOCUI.Ribbon>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.Ribbon,DXOCUI.Ribbon>(value);
    }
  }
  
}
