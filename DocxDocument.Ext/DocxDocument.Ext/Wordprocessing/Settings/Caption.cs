namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the contents and positioning for captions which can be used to automatically label objects in a WordprocessingML document. 
/// A caption is a string that labels an object included in a WordprocessingML document, 
/// and typically consists of a string plus a field which numbers this item within a collection of similar objects.
/// </summary>
[DataContract]
public partial class Caption: ModelElement<DXW.Caption>, INamedElement
{
  public Caption(): base(){ }

  public Caption(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Caption(DXW.Caption openXmlElement): base(openXmlElement) { }

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

  [DataMember]
  public DMW.CaptionPositionKind? Position
  {
    get => _Element?.Position?.GetEnumValue<DMW.CaptionPositionKind, DXW.CaptionPositionValues>();
    set => _ExistingElement.Position = EVU.SetEnumValue<DMW.CaptionPositionKind, DXW.CaptionPositionValues>(value);
  }

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

  [DataMember]
  public DMW.NumberFormatKind? NumberFormat
  {
    get => _Element?.NumberFormat?.GetEnumValue<DMW.NumberFormatKind, DXW.NumberFormatValues>();
    set => _ExistingElement.NumberFormat = EVU.SetEnumValue<DMW.NumberFormatKind, DXW.NumberFormatValues>(value);
  }

  [DataMember]
  public DMW.ChapterSeparatorKind? Separator
  {
    get => _Element?.Separator?.GetEnumValue<DMW.ChapterSeparatorKind, DXW.ChapterSeparatorValues>();
    set => _ExistingElement.Separator = EVU.SetEnumValue<DMW.ChapterSeparatorKind, DXW.ChapterSeparatorValues>(value);
  }

}
