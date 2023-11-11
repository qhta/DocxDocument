namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the ImageControl Class.
/// </summary>
public partial class ImageControl: ModelElement<DXO10CUI.ImageControl>
{
  public ImageControl(): base(){ }
  
  public ImageControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImageControl(DXO10CUI.ImageControl openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
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
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? QualifiedId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.QualifiedId);
    }
    set
    {
      _ExistingElement.QualifiedId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Tag);
    }
    set
    {
      _ExistingElement.Tag = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Enabled
  {
    get
    {
      return _Element?.Enabled?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Enabled = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Enabled = null;
    }
  }
  
  
  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetEnabled
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetEnabled);
    }
    set
    {
      _ExistingElement.GetEnabled = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get
    {
      return _Element?.Visible?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Visible = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Visible = null;
    }
  }
  
  
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetVisible);
    }
    set
    {
      _ExistingElement.GetVisible = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Image
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Image);
    }
    set
    {
      _ExistingElement.Image = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? ImageMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ImageMso);
    }
    set
    {
      _ExistingElement.ImageMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetImage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetImage);
    }
    set
    {
      _ExistingElement.GetImage = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   altText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? AltText
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AltText);
    }
    set
    {
      _ExistingElement.AltText = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getAltText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetAltText
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetAltText);
    }
    set
    {
      _ExistingElement.GetAltText = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
