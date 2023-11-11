namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document-Wide Endnote Properties.
/// </summary>
public partial class EndnoteDocumentWideProperties: ModelElement<DXW.EndnoteDocumentWideProperties>
{
  public EndnoteDocumentWideProperties(): base(){ }
  
  public EndnoteDocumentWideProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EndnoteDocumentWideProperties(DXW.EndnoteDocumentWideProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Endnote Placement.
  /// </summary>
  [DataMember]
  public DMW.EndnotePositionKind? EndnotePosition
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DMW.EndnotePositionKind>(_ExistingElement.GetFirstChild<DXW.EndnotePosition>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EndnotePosition>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DMW.EndnotePositionKind>(itemElement, (DMW.EndnotePositionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.EndnotePosition, DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DMW.EndnotePositionKind>((DMW.EndnotePositionKind)value));
    }
  }
  
  
  /// <summary>
  ///   Endnote Numbering Format.
  /// </summary>
  [DataMember]
  public DMW.NumberingFormat? NumberingFormat
  {
    get
    {
      return _Element?.GetObject<DMW.NumberingFormat,DXW.NumberingFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NumberingFormat,DXW.NumberingFormat>(value);
    }
  }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Starting Value.
  /// </summary>
  [DataMember]
  public UInt16? NumberingStart
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.NumberingStart>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.NumberingStart,System.UInt16>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Restart Location.
  /// </summary>
  [DataMember]
  public DMW.RestartNumberKind? NumberingRestart
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(_ExistingElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingRestart>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(itemElement, (DMW.RestartNumberKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.NumberingRestart, DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>((DMW.RestartNumberKind)value));
    }
  }
  
}
