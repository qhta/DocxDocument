namespace DocumentModel.Drawings.Diagram2;


/// <summary>
///   Defines the TextListStyleType Class.
/// </summary>
public partial class TextListStyleType: ModelElement<DXO19DD12.TextListStyleType>
{
  public TextListStyleType(): base(){ }
  
  public TextListStyleType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextListStyleType(DXO19DD12.TextListStyleType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Default Paragraph Style.
  /// </summary>
  [DataMember]
  public DMD.DefaultParagraphProperties? DefaultParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.DefaultParagraphProperties,DXD.DefaultParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.DefaultParagraphProperties,DXD.DefaultParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 1 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level1ParagraphProperties? Level1ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level1ParagraphProperties,DXD.Level1ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level1ParagraphProperties,DXD.Level1ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 2 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level2ParagraphProperties? Level2ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level2ParagraphProperties,DXD.Level2ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level2ParagraphProperties,DXD.Level2ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 3 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level3ParagraphProperties? Level3ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level3ParagraphProperties,DXD.Level3ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level3ParagraphProperties,DXD.Level3ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 4 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level4ParagraphProperties? Level4ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level4ParagraphProperties,DXD.Level4ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level4ParagraphProperties,DXD.Level4ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 5 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level5ParagraphProperties? Level5ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level5ParagraphProperties,DXD.Level5ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level5ParagraphProperties,DXD.Level5ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 6 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level6ParagraphProperties? Level6ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level6ParagraphProperties,DXD.Level6ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level6ParagraphProperties,DXD.Level6ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 7 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level7ParagraphProperties? Level7ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level7ParagraphProperties,DXD.Level7ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level7ParagraphProperties,DXD.Level7ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 8 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level8ParagraphProperties? Level8ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level8ParagraphProperties,DXD.Level8ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level8ParagraphProperties,DXD.Level8ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   List Level 9 Text Style.
  /// </summary>
  [DataMember]
  public DMD.Level9ParagraphProperties? Level9ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.Level9ParagraphProperties,DXD.Level9ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Level9ParagraphProperties,DXD.Level9ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
