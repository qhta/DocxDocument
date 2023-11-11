namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a set of suggested filters which should be applied to the list of document styles in this application 
/// if the styles are displayed in a user interface.
/// </summary>
[DataContract]
public partial class StylePaneFormatFilter: ModelElement<DXW.StylePaneFormatFilter>
{
  public StylePaneFormatFilter(): base(){ }

  public StylePaneFormatFilter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public StylePaneFormatFilter(DXW.StylePaneFormatFilter openXmlElement): base(openXmlElement) { } 

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
