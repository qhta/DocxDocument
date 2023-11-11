namespace DocumentModel.Drawings;


/// <summary>
///   Text Field.
/// </summary>
public partial class Field: ModelElement<DXD.Field>
{
  public Field(): base(){ }
  
  public Field(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Field(DXD.Field openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Field ID
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Field Type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Type);
    }
    set
    {
      _ExistingElement.Type = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  [DataMember]
  public DMD.RunProperties? RunProperties
  {
    get
    {
      return _Element?.GetObject<DMD.RunProperties,DXD.RunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.RunProperties,DXD.RunProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMD.ParagraphProperties? ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMD.ParagraphProperties,DXD.ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ParagraphProperties,DXD.ParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  [DataMember]
  public DMD.Text? Text
  {
    get
    {
      return _Element?.GetObject<DMD.Text,DXD.Text>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Text,DXD.Text>(value);
    }
  }
  
}
