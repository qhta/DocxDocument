using System.Runtime.Serialization;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a set of suggested filters which should be applied to the list of document styles in this application 
/// if the styles are displayed in a user interface.
/// </summary>
[DataContract]
public partial class StylePaneFormatFilter: IOpenXmlElementMappedObject
{
  public StylePaneFormatFilter()
  {
    _Element = new DXW.StylePaneFormatFilter();
  }

  public StylePaneFormatFilter(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.StylePaneFormatFilter)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public StylePaneFormatFilter(DXW.StylePaneFormatFilter openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.StylePaneFormatFilter _Element { get; private set; }

  [DataMember]
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

  [DataMember]
  public bool? AllStyles
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

  [DataMember]
  public bool? CustomStyles
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

  [DataMember]
  public bool? LatentStyles
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

  [DataMember]
  public bool? StylesInUse
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

  [DataMember]
  public bool? HeadingStyles
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

  [DataMember]
  public bool? NumberingStyles
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

  [DataMember]
  public bool? TableStyles
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

  [DataMember]
  public bool? DirectFormattingOnRuns
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

  [DataMember]
  public bool? DirectFormattingOnParagraphs
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

  [DataMember]
  public bool? DirectFormattingOnNumbering
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

  [DataMember]
  public bool? DirectFormattingOnTables
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

  [DataMember]
  public bool? ClearFormatting
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

  [DataMember]
  public bool? Top3HeadingStyles
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

  [DataMember]
  public bool? VisibleStyles
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

  [DataMember]
  public bool? AlternateStyleNames
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
