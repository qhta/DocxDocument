namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a phonetic guide at the current location in the document. A phonetic guide (often called ruby text) is a run of content with base text which appears at the normal baseline location for text in this run, with phonetic guide text displayed above it in the document. The resulting construct is called a phonetic guide as it is typically used to map words in one language to another phonetically.
/// </summary>
public partial class Ruby: ModelElement<DXW.Ruby>
{
  public Ruby(): base(){ }
  
  public Ruby(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Ruby(DXW.Ruby openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phonetic Guide Properties.
  /// </summary>
  [DataMember]
  public DMW.RubyProperties? RubyProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RubyProperties>();
      if (element != null)
        return RubyPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RubyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RubyPropertiesConverter.CreateOpenXmlElement<DXW.RubyProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Phonetic Guide Text.
  /// </summary>
  [DataMember]
  public DMW.RubyContent? RubyContent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RubyContent>();
      if (element != null)
        return RubyContentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RubyContent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RubyContentConverter.CreateOpenXmlElement<DXW.RubyContent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Phonetic Guide Base Text.
  /// </summary>
  [DataMember]
  public DMW.RubyBase? RubyBase
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RubyBase>();
      if (element != null)
        return RubyBaseConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RubyBase>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RubyBaseConverter.CreateOpenXmlElement<DXW.RubyBase>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
