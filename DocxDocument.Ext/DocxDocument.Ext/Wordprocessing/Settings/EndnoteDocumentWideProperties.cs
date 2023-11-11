namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the endnote properties for the current document. 
/// These properties can be overridden for a specific section via the section-wide EndnotePr element.
/// </summary>
[DataContract]
public partial class EndnoteDocumentWideProperties : ModelElement<DXW.EndnoteDocumentWideProperties>
{
  public EndnoteDocumentWideProperties(): base(){ }

  public EndnoteDocumentWideProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public EndnoteDocumentWideProperties(DXW.EndnoteDocumentWideProperties openXmlElement): base(openXmlElement) { } 


  /// <summary>
  /// This element specifies where endnotes shall be placed on the page when they are referenced by text in the current document.
  /// If this element is present at the section level, then it shall be ignored.
  /// If this element is omitted at the document level, then endnotes shall be located at the end of the document.
  /// </summary>
  [DataMember]
  public DMW.EndnotePositionKind? EndnotePosition
  {
    get => _Element?.GetEnumVal<DMW.EndnotePositionKind,DXW.EndnotePosition>();
    set => _ExistingElement.SetEnumVal<DMW.EndnotePositionKind,DXW.EndnotePosition>(value);
  }

  /// <summary>
  /// This element specifies the starting number or character for the first automatically numbered footnotes or endnote in the document, 
  /// as well as the first automatically numbered footnotes after each restart point specified by the NumRestart element. 
  /// This value shall be specified in decimal number units, then translated accordingly to the appropriate numbering format.
  /// If this element is omitted, then the starting value shall be 1.
  /// </summary>
  [DataMember]
  public int? NumberingStart
  {
    get => _Element?.GetIntVal<DXW.NumberingStart>();
    set => _ExistingElement.SetIntVal<DXW.NumberingStart>(value);
  }

  /// <summary>
  /// This element specifies the ID for all endnotes which are located in the current document that are not of style normal. 
  /// Each other type of endnote shall be referenced in this list, or it shall not be loaded. 
  /// If an endnote is not listed beneath this element, and it is required by the document content, 
  /// then the document shall be considered non-conformant.
  /// </summary>
  [DataMember]
  public int? EndnoteSpecialReference
  {
    get => _Element?.GetIntId<DXW.EndnoteSpecialReference>();
    set => _ExistingElement.SetIntId<DXW.EndnoteSpecialReference>(value);
  }

  /// <summary>
  /// This element specifies the number format which shall be used to display all numbering at this level in the numbering definition. 
  /// This information is used to replace the level text string %x, where x is a particular one-based level index, 
  /// with the appropriate value. This value shall be calculated by counting the number of paragraphs at this level 
  /// since the last restart using the numbering system defined in the val attribute.
  /// When a document has a custom number format specified by the format attribute, it shall use the referenced number format. 
  /// If the referenced number format cannot be resolved as a number format the consumer shall use the number format 
  /// specified by the value of the val attribute. If the corresponding value of the val attribute is custom, 
  /// the result is implementation-defined.
  /// <para>
  /// If this element is omitted, the level shall be assumed to be of level type decimal.
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.NumberFormatKind? NumberingFormat
  {
    get => _Element?.GetEnumVal<DMW.NumberFormatKind,DXW.NumberingFormat>();
    set => _ExistingElement.SetEnumVal<DMW.NumberFormatKind,DXW.NumberingFormat>(value);
  }

  /// <summary>
  /// This element specifies when all automatic numbering for the footnote or endnote reference marks shall be restarted. 
  /// When restarted, the next automatically numbered footnote or endnote in the document 
  /// (each footnote/endnote type is handled independently) shall restart to the specified NumStart value.
  /// <para>
  /// If this element is omitted, then automatic numbering shall not be restarted between each page or section (a value of continuous).
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.RestartNumberKind? NumberingRestart
  {
    get => _Element?.GetEnumVal<DMW.RestartNumberKind,DXW.NumberingRestart>();
    set => _ExistingElement.SetEnumVal<DMW.RestartNumberKind,DXW.NumberingRestart>(value);
  }
}
