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
      var element = _Element?.GetFirstChild<DXDC.ChartObject>();
      if (element != null)
        return ChartObjectConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartObject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartObjectConverter.CreateOpenXmlElement<DXDC.ChartObject>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Data>();
      if (element != null)
        return DataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Data>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataConverter.CreateOpenXmlElement<DXDC.Data>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Formatting>();
      if (element != null)
        return FormattingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Formatting>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormattingConverter.CreateOpenXmlElement<DXDC.Formatting>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Selection>();
      if (element != null)
        return SelectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Selection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SelectionConverter.CreateOpenXmlElement<DXDC.Selection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.UserInterface>();
      if (element != null)
        return UserInterfaceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.UserInterface>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UserInterfaceConverter.CreateOpenXmlElement<DXDC.UserInterface>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
