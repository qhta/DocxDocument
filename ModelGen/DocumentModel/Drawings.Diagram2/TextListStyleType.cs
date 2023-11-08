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
      var element = _Element?.GetFirstChild<DXD.DefaultParagraphProperties>();
      if (element != null)
        return DefaultParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.DefaultParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DefaultParagraphPropertiesConverter.CreateOpenXmlElement<DXD.DefaultParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level1ParagraphProperties>();
      if (element != null)
        return Level1ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level1ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level1ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level1ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level2ParagraphProperties>();
      if (element != null)
        return Level2ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level2ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level2ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level2ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level3ParagraphProperties>();
      if (element != null)
        return Level3ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level3ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level3ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level3ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level4ParagraphProperties>();
      if (element != null)
        return Level4ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level4ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level4ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level4ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level5ParagraphProperties>();
      if (element != null)
        return Level5ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level5ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level5ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level5ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level6ParagraphProperties>();
      if (element != null)
        return Level6ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level6ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level6ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level6ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level7ParagraphProperties>();
      if (element != null)
        return Level7ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level7ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level7ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level7ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level8ParagraphProperties>();
      if (element != null)
        return Level8ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level8ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level8ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level8ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Level9ParagraphProperties>();
      if (element != null)
        return Level9ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Level9ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level9ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level9ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
