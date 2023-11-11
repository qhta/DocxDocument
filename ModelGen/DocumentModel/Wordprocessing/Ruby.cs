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
      return _Element?.GetObject<DMW.RubyProperties,DXW.RubyProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RubyProperties,DXW.RubyProperties>(value);
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
      return _Element?.GetObject<DMW.RubyContent,DXW.RubyContent>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RubyContent,DXW.RubyContent>(value);
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
      return _Element?.GetObject<DMW.RubyBase,DXW.RubyBase>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RubyBase,DXW.RubyBase>(value);
    }
  }
  
}
