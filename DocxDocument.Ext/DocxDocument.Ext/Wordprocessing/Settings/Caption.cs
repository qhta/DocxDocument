namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the contents and positioning for captions which can be used to automatically label objects in a WordprocessingML document. 
/// A caption is a string that labels an object included in a WordprocessingML document, 
/// and typically consists of a string plus a field which numbers this item within a collection of similar objects.
/// </summary>
[DataContract]
public partial class Caption: ModelElement<DXW.Caption>, INamedElement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Caption(): base(){ }

  public Caption(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Caption(DXW.Caption openXmlElement): base(openXmlElement) { }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Specifies the literal string component of this caption.
  /// This value is used as follows:
  /// <list type="bullet">
  ///   <item>
  ///     It is added to the field containing the chapter number and item number of this object 
  ///     when a caption is automatically added to the document.
  ///   </item>
  ///   <item>
  ///     It is used to uniquely label this caption type, allowing it to be linked 
  ///     with classes of objects via the autoCaption element.
  ///   </item>
  ///     It can be used to label this caption type in a user interface.
  ///   <item>
  ///   </item>
  /// </list>
  /// </summary>
  [DataMember]
  public string? Name
  {
    get => _Element?.Name?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Name = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.Name = null;
    }
  }

  /// <summary>
  /// Specifies how an automatically inserted caption shall be positioned relative to the object that it is captioning.
  /// <para>
  /// If this attribute is omitted, then the default value shall be below.
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.CaptionPositionKind? Position
  {
    get => _Element?.Position?.GetEnumValue<DMW.CaptionPositionKind, DXW.CaptionPositionValues>();
    set => _ExistingElement.Position = EVU.SetEnumValue<DMW.CaptionPositionKind, DXW.CaptionPositionValues>(value);
  }

  /// <summary>
  /// Specifies whether or not to display numbering associated with the most recent chapter heading 
  /// in the WordprocessingML document within the caption field. 
  /// A chapter heading is a paragraph of text within a WordprocessingML document 
  /// that is formatted with a style that has been specified by the heading attribute to demarcate chapters in documents.
  /// <para>
  /// Only a style with its styleID attribute equal to 
  /// Heading1, Heading2, Heading3, Heading4, Heading5, Heading6, Heading7, Heading8, or Heading9 
  /// can be specified as the style used to demarcate chapters in a document. 
  /// The choice of which of these heading levels shall be used to determine the current chapter number 
  /// is defined by the value of the corresponding heading attribute. 
  /// </para>
  /// <para>
  /// [Example: Heading1 is used as the chapter heading when chapNum is true and heading is 1. end example]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? ChapterNumber
  {
    get => _Element?.ChapterNumber?.Value;
    set
    {
      if (value != null)
        _ExistingElement.ChapterNumber = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.ChapterNumber = null;
    }
  }

  /// <summary>
  /// Specifies the given style that is used to demarcate chapter headings in a document.
  /// <para>
  /// This value is used to link the chapter headings with paragraphs with a styleID attribute as follows: 
  ///  1 - Style with styleID of Heading1 , 2 - Style with styleID of Heading2 and so on.
  ///  </para>
  /// </summary>
  [DataMember]
  public int? Heading
  {
    get => _Element?.Heading?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Heading = new DX.Int32Value { Value = (Int32)value };
      else
        _ExistingElement.Heading = null;
    }
  }

  /// <summary>
  /// Specifies if the string specified in the name attribute shall be included in the resulting caption 
  /// when it is automatically added to the document. If set to true, then the label text in the name attribute 
  /// is omitted when adding the caption.
  /// </summary>
  [DataMember]
  public bool? NoLabel
  {
    get => _Element?.NoLabel?.Value;
    set
    {
      if (value != null)
        _ExistingElement.NoLabel = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.NoLabel = null;
    }
  }

  /// <summary>
  /// Specifies the format of the numbering which shall be included in an automatically generated caption 
  /// to specify the index of this item in that collection (within the current chapter if chapNum is specified, 
  /// or within the current document story).
  /// <para>
  /// If this attribute is omitted, then its default value shall be assumed to be decimal.
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.NumberFormatKind? NumberFormat
  {
    get => _Element?.NumberFormat?.GetEnumValue<DMW.NumberFormatKind, DXW.NumberFormatValues>();
    set => _ExistingElement.NumberFormat = EVU.SetEnumValue<DMW.NumberFormatKind, DXW.NumberFormatValues>(value);
  }

  /// <summary>
  /// Specifies the character which shall be used to separate the chapter number used in this caption 
  /// from the caption item numbering. A caption format consists of three components:
  /// <list type="bullet">
  ///   <item>
  ///     The (optional) literal string
  ///   </item>
  ///   <item>
  ///     The (optional) chapter number
  ///   </item>
  ///   <item>
  ///     The index of this caption within the chapter/document
  ///   </item>
  /// </list>
  /// <para>
  /// When the latter two items are both present, they are delimited using the chapter separator specified by this attribute.
  /// If this attribute is omitted, then its default value shall be hyphen. 
  /// If the chapter number is not part of the caption format, then this parameter shall be ignored.  
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.ChapterSeparatorKind? Separator
  {
    get => _Element?.Separator?.GetEnumValue<DMW.ChapterSeparatorKind, DXW.ChapterSeparatorValues>();
    set => _ExistingElement.Separator = EVU.SetEnumValue<DMW.ChapterSeparatorKind, DXW.ChapterSeparatorValues>(value);
  }

}
