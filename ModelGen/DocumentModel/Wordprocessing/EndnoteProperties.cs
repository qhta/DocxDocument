namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the EndnoteProperties Class.
/// </summary>
public partial class EndnoteProperties: ModelElement<DXW.EndnoteProperties>
{
  public EndnoteProperties(): base(){ }
  
  public EndnoteProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EndnoteProperties(DXW.EndnoteProperties openXmlElement): base(openXmlElement) { }
  
  
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
      var element = _Element?.GetFirstChild<DXW.NumberingFormat>();
      if (element != null)
        return NumberingFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DXW.NumberingFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXW.NumberingStart,System.UInt16>(openXmlElement, value);
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
