namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageNumberType Class.
/// </summary>
public partial class PageNumberType: ModelElement<DXW.PageNumberType>
{
  public PageNumberType(): base(){ }
  
  public PageNumberType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageNumberType(DXW.PageNumberType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Starting Page Number
  /// </summary>
  [DataMember]
  public Int32? Start
  {
    get
    {
      return _Element?.Start?.Value;
    }
    set
    {
      _ExistingElement.Start = value;
    }
  }
  
  
  /// <summary>
  ///   Chapter Heading Style
  /// </summary>
  [DataMember]
  public Byte? ChapterStyle
  {
    get
    {
      return _Element?.ChapterStyle?.Value;
    }
    set
    {
      _ExistingElement.ChapterStyle = value;
    }
  }
  
}
