namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a set of suggested filters which should be applied to the list of document styles in this application 
/// if the styles are displayed in a user interface.
/// </summary>
[DataContract]
public partial class StylePaneFormatFilter: ModelElement<DXW.StylePaneFormatFilter>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public StylePaneFormatFilter(): base(){ }

  public StylePaneFormatFilter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public StylePaneFormatFilter(DXW.StylePaneFormatFilter openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Hexadecimally encoded value of all boolean properties.
  /// </summary>
  [DataMember]
  public HexWord? Val
  {
    get
    {
      var val = _Element?.Val?.Value;
      if (val == null) return null;
      return new HexWord(val);
    }
    set
    {
      if (value != null)
        _ExistingElement.Val = new DX.HexBinaryValue { Value = ((HexWord)value).ToString() };
      else
        _ExistingElement.Val = null;
    }
  }

  /// <summary>
  /// Specifies that all styles present in the Styles part should be displayed in the list of document styles.
  /// </summary>
  [DataMember]
  public bool? AllStyles
  {
    get => _Element?.AllStyles?.Value;
    set
    {
      if (value != null)
        _ExistingElement.AllStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.AllStyles = null;
    }
  }

  /// <summary>
  /// Specifies that only styles with the customStyle attribute should be displayed in the list of document styles.
  /// </summary>
  [DataMember]
  public bool? CustomStyles
  {
    get => _Element?.CustomStyles?.Value;
    set
    {
      if (value != null)
        _ExistingElement.CustomStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.CustomStyles = null;
    }
  }

  /// <summary>
  /// Specifies that all latent styles should be displayed in the list of document styles.
  /// </summary>
  [DataMember]
  public bool? LatentStyles
  {
    get => _Element?.LatentStyles?.Value;
    set
    {
      if (value != null)
        _ExistingElement.LatentStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.LatentStyles = null;
    }
  }

  /// <summary>
  /// Specifies that only styles used in the document should be displayed in the list of document styles.
  /// </summary>
  [DataMember]
  public bool? StylesInUse
  {
    get => _Element?.StylesInUse?.Value;
    set
    {
      if (value != null)
        _ExistingElement.StylesInUse = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.StylesInUse = null;
    }
  }

  /// <summary>
  /// Specifies that heading styles (styles with a styleId of Heading1 to Heading9) should be displayed 
  /// in the list of document styles when the previous style is used in the document and/or is present in the Styles part.
  /// </summary>
  [DataMember]
  public bool? HeadingStyles
  {
    get => _Element?.HeadingStyles?.Value;
    set
    {
      if (value != null)
        _ExistingElement.HeadingStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.HeadingStyles = null;
    }
  }

  /// <summary>
  /// Specifies that numbering styles should be displayed in the list of document styles.
  /// </summary>
  [DataMember]
  public bool? NumberingStyles
  {
    get => _Element?.HeadingStyles?.Value;
    set
    {
      if (value != null)
        _ExistingElement.NumberingStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.NumberingStyles = null;
    }
  }

  /// <summary>
  /// Specifies that table styles should be displayed in the list of document styles.
  /// </summary>
  [DataMember]
  public bool? TableStyles
  {
    get => _Element?.TableStyles?.Value;
    set
    {
      if (value != null)
        _ExistingElement.TableStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.TableStyles = null;
    }
  }

  /// <summary>
  /// Specifies that all unique forms of run-level direct formatting should be displayed 
  /// in the list of document styles as though they were each a unique style.
  /// </summary>
  [DataMember]
  public bool? DirectFormattingOnRuns
  {
    get => _Element?.DirectFormattingOnRuns?.Value;
    set
    {
      if (value != null)
        _ExistingElement.DirectFormattingOnRuns = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.DirectFormattingOnRuns = null;
    }
  }

  /// <summary>
  /// Specifies that all unique forms of paragraph-level direct formatting should be displayed 
  /// in the list of document styles as though they were each a unique style.
  /// </summary>
  [DataMember]
  public bool? DirectFormattingOnParagraphs
  {
    get => _Element?.DirectFormattingOnParagraphs?.Value;
    set
    {
      if (value != null)
        _ExistingElement.DirectFormattingOnParagraphs = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.DirectFormattingOnParagraphs = null;
    }
  }

  /// <summary>
  /// Specifies that all unique forms of direct formatting of numbering data should be displayed 
  /// in the list of document styles as though they were each a unique style.
  /// </summary>
  [DataMember]
  public bool? DirectFormattingOnNumbering
  {
    get => _Element?.DirectFormattingOnParagraphs?.Value;
    set
    {
      if (value != null)
        _ExistingElement.DirectFormattingOnNumbering = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.DirectFormattingOnNumbering = null;
    }
  }

  /// <summary>
  /// Specifies that all unique forms of direct formatting of tables should be displayed 
  /// in the list of document styles as though they were each a unique style.
  /// </summary>
  [DataMember]
  public bool? DirectFormattingOnTables
  {
    get => _Element?.DirectFormattingOnTables?.Value;
    set
    {
      if (value != null)
        _ExistingElement.DirectFormattingOnTables = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.DirectFormattingOnTables = null;
    }
  }

  /// <summary>
  /// Specifies that a style should be present which removes all formatting and styles from text.
  /// </summary>
  [DataMember]
  public bool? ClearFormatting
  {
    get => _Element?.ClearFormatting?.Value;
    set
    {
      if (value != null)
        _ExistingElement.ClearFormatting = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.ClearFormatting = null;
    }
  }

  /// <summary>
  /// Specifies that heading styles with a styleId of Heading1 to Heading3 should always be displayed in the list of document styles.
  /// </summary>
  [DataMember]
  public bool? Top3HeadingStyles
  {
    get => _Element?.Top3HeadingStyles?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Top3HeadingStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.Top3HeadingStyles = null;
    }
  }

  /// <summary>
  /// Specifies that styles should only be shown if the semiHidden element is false and the hidden element is false.
  /// </summary>
  [DataMember]
  public bool? VisibleStyles
  {
    get => _Element?.VisibleStyles?.Value;
    set
    {
      if (value != null)
        _ExistingElement.VisibleStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.VisibleStyles = null;
    }
  }

  /// <summary>
  /// Specifies that primary names for styles should not be shown if an alternate name using the name element exists.
  /// </summary>
  [DataMember]
  public bool? AlternateStyleNames
  {
    get => _Element?.AlternateStyleNames?.Value;
    set
    {
      if (value != null)
        _ExistingElement.AlternateStyleNames = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.AlternateStyleNames = null;
    }
  }

}
