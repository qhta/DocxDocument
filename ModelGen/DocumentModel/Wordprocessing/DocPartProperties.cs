namespace DocumentModel.Wordprocessing;


/// <summary>
///   Glossary Document Entry Properties.
/// </summary>
public partial class DocPartProperties: ModelElement<DXW.DocPartProperties>
{
  public DocPartProperties(): base(){ }
  
  public DocPartProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartProperties(DXW.DocPartProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Entry Name.
  /// </summary>
  [DataMember]
  public DMW.DocPartName? DocPartName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocPartName>();
      if (element != null)
        return DocPartNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocPartName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartNameConverter.CreateOpenXmlElement<DXW.DocPartName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Associated Paragraph Style Name.
  /// </summary>
  [DataMember]
  public DMW.StyleId? StyleId
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.StyleId>();
      if (element != null)
        return StyleIdConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StyleId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleIdConverter.CreateOpenXmlElement<DXW.StyleId>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Entry Categorization.
  /// </summary>
  [DataMember]
  public DMW.Category? Category
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Category>();
      if (element != null)
        return CategoryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Category>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryConverter.CreateOpenXmlElement<DXW.Category>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Entry Types.
  /// </summary>
  [DataMember]
  public DMW.DocPartTypes? DocPartTypes
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocPartTypes>();
      if (element != null)
        return DocPartTypesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocPartTypes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartTypesConverter.CreateOpenXmlElement<DXW.DocPartTypes>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Entry Insertion Behaviors.
  /// </summary>
  [DataMember]
  public DMW.Behaviors? Behaviors
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Behaviors>();
      if (element != null)
        return BehaviorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Behaviors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BehaviorsConverter.CreateOpenXmlElement<DXW.Behaviors>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Description for Entry.
  /// </summary>
  [DataMember]
  public DMW.Description? Description
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Description>();
      if (element != null)
        return DescriptionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Description>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DescriptionConverter.CreateOpenXmlElement<DXW.Description>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Entry ID.
  /// </summary>
  [DataMember]
  public String? DocPartId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXW.DocPartId>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXW.DocPartId>(openXmlElement, value);
    }
  }
  
}
