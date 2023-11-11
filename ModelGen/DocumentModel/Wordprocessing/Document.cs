namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a main document part in a WordprocessingML document.
/// </summary>
public partial class Document: ModelElement<DXW.Document>
{
  public Document(): base(){ }
  
  public Document(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Document(DXW.Document openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Background.
  /// </summary>
  [DataMember]
  public DMW.DocumentBackground? DocumentBackground
  {
    get
    {
      return _Element?.GetObject<DMW.DocumentBackground,DXW.DocumentBackground>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocumentBackground,DXW.DocumentBackground>(value);
    }
  }
  
  
  /// <summary>
  ///   Body.
  /// </summary>
  [DataMember]
  public DMW.Body? Body
  {
    get
    {
      return _Element?.GetObject<DMW.Body,DXW.Body>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Body,DXW.Body>(value);
    }
  }
  
}
