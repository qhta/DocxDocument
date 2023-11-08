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
      var element = _Element?.GetFirstChild<DXOCUI.RepurposedCommands>();
      if (element != null)
        return RepurposedCommandsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.RepurposedCommands>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RepurposedCommandsConverter.CreateOpenXmlElement<DXOCUI.RepurposedCommands>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXOCUI.Ribbon>();
      if (element != null)
        return RibbonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.Ribbon>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RibbonConverter.CreateOpenXmlElement<DXOCUI.Ribbon>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
