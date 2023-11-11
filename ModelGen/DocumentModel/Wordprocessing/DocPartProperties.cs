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
      return _Element?.GetObject<DMW.DocPartName,DXW.DocPartName>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartName,DXW.DocPartName>(value);
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
      return _Element?.GetObject<DMW.StyleId,DXW.StyleId>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StyleId,DXW.StyleId>(value);
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
      return _Element?.GetObject<DMW.Category,DXW.Category>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Category,DXW.Category>(value);
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
      return _Element?.GetObject<DMW.DocPartTypes,DXW.DocPartTypes>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartTypes,DXW.DocPartTypes>(value);
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
      return _Element?.GetObject<DMW.Behaviors,DXW.Behaviors>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Behaviors,DXW.Behaviors>(value);
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
      return _Element?.GetObject<DMW.Description,DXW.Description>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Description,DXW.Description>(value);
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
      StringValueConverter.SetValue<DXW.DocPartId>(_ExistingElement, value);
    }
  }
  
}
