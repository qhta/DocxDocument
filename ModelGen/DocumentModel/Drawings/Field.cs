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
      var element = _Element?.GetFirstChild<DXD.RunProperties>();
      if (element != null)
        return RunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DXD.RunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ParagraphProperties>();
      if (element != null)
        return ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Text>();
      if (element != null)
        return TextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Text>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextConverter.CreateOpenXmlElement<DXD.Text>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
