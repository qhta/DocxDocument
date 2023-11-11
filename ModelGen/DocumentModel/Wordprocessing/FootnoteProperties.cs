namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteProperties Class.
/// </summary>
public partial class FootnoteProperties: ModelElement<DXW.FootnoteProperties>
{
  public FootnoteProperties(): base(){ }
  
  public FootnoteProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteProperties(DXW.FootnoteProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  [DataMember]
  public DMW.FootnotePositionKind? FootnotePosition
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>(_ExistingElement.GetFirstChild<DXW.FootnotePosition>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FootnotePosition>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>(itemElement, (DMW.FootnotePositionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.FootnotePosition, DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>((DMW.FootnotePositionKind)value));
    }
  }
  
  
  /// <summary>
  ///   Footnote Numbering Format.
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
