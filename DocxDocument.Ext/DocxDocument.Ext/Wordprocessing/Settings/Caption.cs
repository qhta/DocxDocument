namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the contents and positioning for captions which can be used to automatically label objects in a WordprocessingML document. 
/// A caption is a string that labels an object included in a WordprocessingML document, 
/// and typically consists of a string plus a field which numbers this item within a collection of similar objects.
/// </summary>
public partial class Caption
{
  public Caption(DXW.Caption openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.Caption _Element { get; private set; }

  public String? Name
  {
    get => _Element.Name?.Value;
    set
    {
      if (value != null)
        _Element.Name = new DX.StringValue { Value = (string)value };
      else
        _Element.Name = null;
    }
  }

  public DXW.CaptionPositionValues? Position
  {
    get => _Element.Position?.Value;
    set
    {
      if (value != null)
        _Element.Position = new DX.EnumValue<DXW.CaptionPositionValues> { Value = (DXW.CaptionPositionValues)value };
      else
        _Element.Position = null;
    }
  }

  public Boolean? ChapterNumber
  {
    get => _Element.ChapterNumber?.Value;
    set
    {
      if (value != null)
        _Element.ChapterNumber = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.ChapterNumber = null;
    }
  }

  public Int32? Heading
  {
    get => _Element.Heading?.Value;
    set
    {
      if (value != null)
        _Element.Heading = new DX.Int32Value { Value = (Int32)value };
      else
        _Element.Heading = null;
    }
  }

  public Boolean? NoLabel
  {
    get => _Element.NoLabel?.Value;
    set
    {
      if (value != null)
        _Element.NoLabel = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.NoLabel = null;
    }
  }

  public DXW.NumberFormatValues? NumberFormat
  {
    get => _Element.NumberFormat?.Value;
    set
    {
      if (value != null)
        _Element.NumberFormat = new DX.EnumValue<DXW.NumberFormatValues> { Value = (DXW.NumberFormatValues)value };
      else
        _Element.NumberFormat = null;
    }
  }

  public DXW.ChapterSeparatorValues? Separator
  {
    get => _Element.Separator?.Value;
    set
    {
      if (value != null)
        _Element.Separator = new DX.EnumValue<DXW.ChapterSeparatorValues> { Value = (DXW.ChapterSeparatorValues)value };
      else
        _Element.Separator = null;
    }
  }

}
