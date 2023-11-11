namespace DocumentModel.Vml;


/// <summary>
///   Defines the ImageData Class.
/// </summary>
public partial class ImageData: ModelElement<DXV.ImageData>
{
  public ImageData(): base(){ }
  
  public ImageData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImageData(DXV.ImageData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
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
  ///   Image Transparency Color
  /// </summary>
  [DataMember]
  public String? ChromAKey
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ChromAKey);
    }
    set
    {
      _ExistingElement.ChromAKey = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Left Crop
  /// </summary>
  [DataMember]
  public String? CropLeft
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CropLeft);
    }
    set
    {
      _ExistingElement.CropLeft = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Top Crop
  /// </summary>
  [DataMember]
  public String? CropTop
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CropTop);
    }
    set
    {
      _ExistingElement.CropTop = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Right Crop
  /// </summary>
  [DataMember]
  public String? CropRight
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CropRight);
    }
    set
    {
      _ExistingElement.CropRight = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Bottom Crop
  /// </summary>
  [DataMember]
  public String? CropBottom
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CropBottom);
    }
    set
    {
      _ExistingElement.CropBottom = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Intensity
  /// </summary>
  [DataMember]
  public String? Gain
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Gain);
    }
    set
    {
      _ExistingElement.Gain = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Brightness
  /// </summary>
  [DataMember]
  public String? BlackLevel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.BlackLevel);
    }
    set
    {
      _ExistingElement.BlackLevel = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Gamma Correction
  /// </summary>
  [DataMember]
  public String? Gamma
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Gamma);
    }
    set
    {
      _ExistingElement.Gamma = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Grayscale Toggle
  /// </summary>
  [DataMember]
  public Boolean? Grayscale
  {
    get
    {
      return _Element?.Grayscale?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Grayscale = value;
      else
        _ExistingElement.Grayscale = null;
    }
  }
  
  
  /// <summary>
  ///   Image Bilevel Toggle
  /// </summary>
  [DataMember]
  public Boolean? BiLevel
  {
    get
    {
      return _Element?.BiLevel?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.BiLevel = value;
      else
        _ExistingElement.BiLevel = null;
    }
  }
  
  
  /// <summary>
  ///   Embossed Color
  /// </summary>
  [DataMember]
  public String? EmbossColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.EmbossColor);
    }
    set
    {
      _ExistingElement.EmbossColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Black Recoloring Color
  /// </summary>
  [DataMember]
  public String? RecolorTarget
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RecolorTarget);
    }
    set
    {
      _ExistingElement.RecolorTarget = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Image Data Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Title);
    }
    set
    {
      _ExistingElement.Title = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  [DataMember]
  public Boolean? DetectMouseClick
  {
    get
    {
      return _Element?.DetectMouseClick?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.DetectMouseClick = value;
      else
        _ExistingElement.DetectMouseClick = null;
    }
  }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? RelId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RelId);
    }
    set
    {
      _ExistingElement.RelId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Explicit Relationship to Image Data
  /// </summary>
  [DataMember]
  public String? RelationshipId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RelationshipId);
    }
    set
    {
      _ExistingElement.RelationshipId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Explicit Relationship to Alternate Image Data
  /// </summary>
  [DataMember]
  public String? Picture
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Picture);
    }
    set
    {
      _ExistingElement.Picture = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Explicit Relationship to Hyperlink Target
  /// </summary>
  [DataMember]
  public String? RelHref
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RelHref);
    }
    set
    {
      _ExistingElement.RelHref = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
