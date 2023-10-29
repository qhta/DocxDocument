namespace DocumentModel;

/// <summary>
/// Specifies a set of suggested filters which should be applied to the list of document styles in this application 
/// if the styles are displayed in a user interface.
/// </summary>
public partial class StylePaneFormatFilter
{
  public StylePaneFormatFilter(DXW.StylePaneFormatFilter openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.StylePaneFormatFilter _Element { get; private set; }

  public HexWord? Val
  {
    get
    {
      var val = _Element.Val?.Value;
      if (val == null) return null;
      return new HexWord(val);
    }
    set
    {
      if (value != null)
        _Element.Val = new DX.HexBinaryValue { Value = ((HexWord)value).ToString() };
      else
        _Element.Val = null;
    }
  }

  public Boolean? AllStyles
  {
    get => _Element.AllStyles?.Value;
    set
    {
      if (value != null)
        _Element.AllStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.AllStyles = null;
    }
  }

  public Boolean? CustomStyles
  {
    get => _Element.CustomStyles?.Value;
    set
    {
      if (value != null)
        _Element.CustomStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.CustomStyles = null;
    }
  }

  public Boolean? LatentStyles
  {
    get => _Element.LatentStyles?.Value;
    set
    {
      if (value != null)
        _Element.LatentStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.LatentStyles = null;
    }
  }

  public Boolean? StylesInUse
  {
    get => _Element.StylesInUse?.Value;
    set
    {
      if (value != null)
        _Element.StylesInUse = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.StylesInUse = null;
    }
  }

  public Boolean? HeadingStyles
  {
    get => _Element.HeadingStyles?.Value;
    set
    {
      if (value != null)
        _Element.HeadingStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.HeadingStyles = null;
    }
  }

  public Boolean? NumberingStyles
  {
    get => _Element.HeadingStyles?.Value;
    set
    {
      if (value != null)
        _Element.NumberingStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.NumberingStyles = null;
    }
  }

  public Boolean? TableStyles
  {
    get => _Element.TableStyles?.Value;
    set
    {
      if (value != null)
        _Element.TableStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.TableStyles = null;
    }
  }

  public Boolean? DirectFormattingOnRuns
  {
    get => _Element.DirectFormattingOnRuns?.Value;
    set
    {
      if (value != null)
        _Element.DirectFormattingOnRuns = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.DirectFormattingOnRuns = null;
    }
  }

  public Boolean? DirectFormattingOnParagraphs
  {
    get => _Element.DirectFormattingOnParagraphs?.Value;
    set
    {
      if (value != null)
        _Element.DirectFormattingOnParagraphs = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.DirectFormattingOnParagraphs = null;
    }
  }

  public Boolean? DirectFormattingOnNumbering
  {
    get => _Element.DirectFormattingOnParagraphs?.Value;
    set
    {
      if (value != null)
        _Element.DirectFormattingOnNumbering = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.DirectFormattingOnNumbering = null;
    }
  }

  public Boolean? DirectFormattingOnTables
  {
    get => _Element.DirectFormattingOnTables?.Value;
    set
    {
      if (value != null)
        _Element.DirectFormattingOnTables = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.DirectFormattingOnTables = null;
    }
  }

  public Boolean? ClearFormatting
  {
    get => _Element.ClearFormatting?.Value;
    set
    {
      if (value != null)
        _Element.ClearFormatting = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.ClearFormatting = null;
    }
  }

  public Boolean? Top3HeadingStyles
  {
    get => _Element.Top3HeadingStyles?.Value;
    set
    {
      if (value != null)
        _Element.Top3HeadingStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.Top3HeadingStyles = null;
    }
  }

  public Boolean? VisibleStyles
  {
    get => _Element.VisibleStyles?.Value;
    set
    {
      if (value != null)
        _Element.VisibleStyles = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.VisibleStyles = null;
    }
  }

  public Boolean? AlternateStyleNames
  {
    get => _Element.AlternateStyleNames?.Value;
    set
    {
      if (value != null)
        _Element.AlternateStyleNames = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.AlternateStyleNames = null;
    }
  }

}
