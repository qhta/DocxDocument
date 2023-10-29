namespace DocumentModel;

/// <summary>
/// Specifies the contents and positioning for captions which can be used to automatically label objects in a WordprocessingML document. 
/// A caption is a string that labels an object included in a WordprocessingML document, 
/// and typically consists of a string plus a field which numbers this item within a collection of similar objects.
/// </summary>
public partial class Caption
{
  public Caption(DXW.Caption caption)
  {
    _Caption = caption;
  }

  internal DXW.Caption _Caption { get; private set; }

  public String? Name
  {
    get => _Caption.Name?.Value;
    set
    {
      if (value != null)
        _Caption.Name = new DX.StringValue { Value = (string)value };
      else
        _Caption.Name = null;
    }
  }

  public DXW.CaptionPositionValues? Position
  {
    get => _Caption.Position?.Value;
    set
    {
      if (value != null)
        _Caption.Position = new DX.EnumValue<DXW.CaptionPositionValues> { Value = (DXW.CaptionPositionValues)value };
      else
        _Caption.Position = null;
    }
  }

  public Boolean? ChapterNumber
  {
    get => _Caption.ChapterNumber?.Value;
    set
    {
      if (value != null)
        _Caption.ChapterNumber = new DX.OnOffValue { Value = (bool)value };
      else
        _Caption.ChapterNumber = null;
    }
  }

  public Int32? Heading
  {
    get => _Caption.Heading?.Value;
    set
    {
      if (value != null)
        _Caption.Heading = new DX.Int32Value { Value = (Int32)value };
      else
        _Caption.Heading = null;
    }
  }

  public Boolean? NoLabel
  {
    get => _Caption.NoLabel?.Value;
    set
    {
      if (value != null)
        _Caption.NoLabel = new DX.OnOffValue { Value = (bool)value };
      else
        _Caption.NoLabel = null;
    }
  }

  public DXW.NumberFormatValues? NumberFormat
  {
    get => _Caption.NumberFormat?.Value;
    set
    {
      if (value != null)
        _Caption.NumberFormat = new DX.EnumValue<DXW.NumberFormatValues> { Value = (DXW.NumberFormatValues)value };
      else
        _Caption.NumberFormat = null;
    }
  }

  public DXW.ChapterSeparatorValues? Separator
  {
    get => _Caption.Separator?.Value;
    set
    {
      if (value != null)
        _Caption.Separator = new DX.EnumValue<DXW.ChapterSeparatorValues> { Value = (DXW.ChapterSeparatorValues)value };
      else
        _Caption.Separator = null;
    }
  }

}
