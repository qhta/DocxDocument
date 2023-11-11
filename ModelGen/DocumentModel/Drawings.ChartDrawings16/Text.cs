namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Text Class.
/// </summary>
public partial class Text: ModelElement<DXO16DCD.Text>
{
  public Text(): base(){ }
  
  public Text(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Text(DXO16DCD.Text openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TextData.
  /// </summary>
  [DataMember]
  public DMDCD16.TextData? TextData
  {
    get
    {
      return _Element?.GetObject<DMDCD16.TextData,DXO16DCD.TextData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.TextData,DXO16DCD.TextData>(value);
    }
  }
  
  
  /// <summary>
  ///   RichTextBody.
  /// </summary>
  [DataMember]
  public DMDCD16.RichTextBody? RichTextBody
  {
    get
    {
      return _Element?.GetObject<DMDCD16.RichTextBody,DXO16DCD.RichTextBody>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.RichTextBody,DXO16DCD.RichTextBody>(value);
    }
  }
  
}
