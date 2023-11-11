namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a paragraph of content in the document.
/// </summary>
public partial class Paragraph: ModelElement<DXW.Paragraph>
{
  public Paragraph(): base(){ }
  
  public Paragraph(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Paragraph(DXW.Paragraph openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidParagraphMarkRevision
  {
    get
    {
      if (_Element?.RsidParagraphMarkRevision?.Value != null)
        return HexIntConverter.GetValue(_Element?.RsidParagraphMarkRevision.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidParagraphMarkRevision = value.ToString();
      else
        _ExistingElement.RsidParagraphMarkRevision = null;
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidParagraphAddition
  {
    get
    {
      if (_Element?.RsidParagraphAddition?.Value != null)
        return HexIntConverter.GetValue(_Element?.RsidParagraphAddition.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidParagraphAddition = value.ToString();
      else
        _ExistingElement.RsidParagraphAddition = null;
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Deletion
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidParagraphDeletion
  {
    get
    {
      if (_Element?.RsidParagraphDeletion?.Value != null)
        return HexIntConverter.GetValue(_Element?.RsidParagraphDeletion.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidParagraphDeletion = value.ToString();
      else
        _ExistingElement.RsidParagraphDeletion = null;
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Properties
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidParagraphProperties
  {
    get
    {
      if (_Element?.RsidParagraphProperties?.Value != null)
        return HexIntConverter.GetValue(_Element?.RsidParagraphProperties.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidParagraphProperties = value.ToString();
      else
        _ExistingElement.RsidParagraphProperties = null;
    }
  }
  
  
  /// <summary>
  ///   Default Revision Identifier for Runs
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRunAdditionDefault
  {
    get
    {
      if (_Element?.RsidRunAdditionDefault?.Value != null)
        return HexIntConverter.GetValue(_Element?.RsidRunAdditionDefault.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidRunAdditionDefault = value.ToString();
      else
        _ExistingElement.RsidRunAdditionDefault = null;
    }
  }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParagraphId
  {
    get
    {
      if (_Element?.ParagraphId?.Value != null)
        return HexIntConverter.GetValue(_Element?.ParagraphId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.ParagraphId = value.ToString();
      else
        _ExistingElement.ParagraphId = null;
    }
  }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? TextId
  {
    get
    {
      if (_Element?.TextId?.Value != null)
        return HexIntConverter.GetValue(_Element?.TextId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.TextId = value.ToString();
      else
        _ExistingElement.TextId = null;
    }
  }
  
  
  /// <summary>
  ///   noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? NoSpellError
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.NoSpellError);
    }
    set
    {
      _ExistingElement.NoSpellError = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.ParagraphProperties? ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMW.ParagraphProperties,DXW.ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ParagraphProperties,DXW.ParagraphProperties>(value);
    }
  }
  
}
