namespace DocumentModel.Vml;


/// <summary>
///   Shape Group.
/// </summary>
public partial class Group: ModelElement<DXV.Group>
{
  public Group(): base(){ }
  
  public Group(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Group(DXV.Group openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Shape Styling Properties
  /// </summary>
  [DataMember]
  public String? Style
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Style);
    }
    set
    {
      _ExistingElement.Style = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  [DataMember]
  public String? Href
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Href);
    }
    set
    {
      _ExistingElement.Href = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Hyperlink Display Target
  /// </summary>
  [DataMember]
  public String? Target
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Target);
    }
    set
    {
      _ExistingElement.Target = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   CSS Reference
  /// </summary>
  [DataMember]
  public String? Class
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Class);
    }
    set
    {
      _ExistingElement.Class = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Title
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
  ///   Alternate Text
  /// </summary>
  [DataMember]
  public String? Alternate
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Alternate);
    }
    set
    {
      _ExistingElement.Alternate = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Coordinate Space Size
  /// </summary>
  [DataMember]
  public String? CoordinateSize
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CoordinateSize);
    }
    set
    {
      _ExistingElement.CoordinateSize = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Coordinate Space Origin
  /// </summary>
  [DataMember]
  public String? CoordinateOrigin
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CoordinateOrigin);
    }
    set
    {
      _ExistingElement.CoordinateOrigin = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Bounding Polygon
  /// </summary>
  [DataMember]
  public String? WrapCoordinates
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.WrapCoordinates);
    }
    set
    {
      _ExistingElement.WrapCoordinates = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Print Toggle
  /// </summary>
  [DataMember]
  public Boolean? Print
  {
    get
    {
      return _Element?.Print?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Print = value;
      else
        _ExistingElement.Print = null;
    }
  }
  
  
  /// <summary>
  ///   spid
  /// </summary>
  [DataMember]
  public String? OptionalString
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OptionalString);
    }
    set
    {
      _ExistingElement.OptionalString = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   oned
  /// </summary>
  [DataMember]
  public Boolean? Oned
  {
    get
    {
      return _Element?.Oned?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Oned = value;
      else
        _ExistingElement.Oned = null;
    }
  }
  
  
  /// <summary>
  ///   regroupid
  /// </summary>
  [DataMember]
  public Int64? RegroupId
  {
    get
    {
      return _Element?.RegroupId?.Value;
    }
    set
    {
      _ExistingElement.RegroupId = value;
    }
  }
  
  
  /// <summary>
  ///   doubleclicknotify
  /// </summary>
  [DataMember]
  public Boolean? DoubleClickNotify
  {
    get
    {
      return _Element?.DoubleClickNotify?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.DoubleClickNotify = value;
      else
        _ExistingElement.DoubleClickNotify = null;
    }
  }
  
  
  /// <summary>
  ///   button
  /// </summary>
  [DataMember]
  public Boolean? Button
  {
    get
    {
      return _Element?.Button?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Button = value;
      else
        _ExistingElement.Button = null;
    }
  }
  
  
  /// <summary>
  ///   userhidden
  /// </summary>
  [DataMember]
  public Boolean? UserHidden
  {
    get
    {
      return _Element?.UserHidden?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UserHidden = value;
      else
        _ExistingElement.UserHidden = null;
    }
  }
  
  
  /// <summary>
  ///   bullet
  /// </summary>
  [DataMember]
  public Boolean? Bullet
  {
    get
    {
      return _Element?.Bullet?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Bullet = value;
      else
        _ExistingElement.Bullet = null;
    }
  }
  
  
  /// <summary>
  ///   hr
  /// </summary>
  [DataMember]
  public Boolean? Horizontal
  {
    get
    {
      return _Element?.Horizontal?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Horizontal = value;
      else
        _ExistingElement.Horizontal = null;
    }
  }
  
  
  /// <summary>
  ///   hrstd
  /// </summary>
  [DataMember]
  public Boolean? HorizontalStandard
  {
    get
    {
      return _Element?.HorizontalStandard?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.HorizontalStandard = value;
      else
        _ExistingElement.HorizontalStandard = null;
    }
  }
  
  
  /// <summary>
  ///   hrnoshade
  /// </summary>
  [DataMember]
  public Boolean? HorizontalNoShade
  {
    get
    {
      return _Element?.HorizontalNoShade?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.HorizontalNoShade = value;
      else
        _ExistingElement.HorizontalNoShade = null;
    }
  }
  
  
  /// <summary>
  ///   hrpct
  /// </summary>
  [DataMember]
  public Single? HorizontalPercentage
  {
    get
    {
      return _Element?.HorizontalPercentage?.Value;
    }
    set
    {
      _ExistingElement.HorizontalPercentage = value;
    }
  }
  
  
  /// <summary>
  ///   allowincell
  /// </summary>
  [DataMember]
  public Boolean? AllowInCell
  {
    get
    {
      return _Element?.AllowInCell?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowInCell = value;
      else
        _ExistingElement.AllowInCell = null;
    }
  }
  
  
  /// <summary>
  ///   allowoverlap
  /// </summary>
  [DataMember]
  public Boolean? AllowOverlap
  {
    get
    {
      return _Element?.AllowOverlap?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowOverlap = value;
      else
        _ExistingElement.AllowOverlap = null;
    }
  }
  
  
  /// <summary>
  ///   userdrawn
  /// </summary>
  [DataMember]
  public Boolean? UserDrawn
  {
    get
    {
      return _Element?.UserDrawn?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UserDrawn = value;
      else
        _ExistingElement.UserDrawn = null;
    }
  }
  
  
  /// <summary>
  ///   dgmlayout
  /// </summary>
  [DataMember]
  public Int64? DiagramLayout
  {
    get
    {
      return _Element?.DiagramLayout?.Value;
    }
    set
    {
      _ExistingElement.DiagramLayout = value;
    }
  }
  
  
  /// <summary>
  ///   dgmnodekind
  /// </summary>
  [DataMember]
  public Int64? DiagramNodeKind
  {
    get
    {
      return _Element?.DiagramNodeKind?.Value;
    }
    set
    {
      _ExistingElement.DiagramNodeKind = value;
    }
  }
  
  
  /// <summary>
  ///   dgmlayoutmru
  /// </summary>
  [DataMember]
  public Int64? DiagramLayoutMostRecentUsed
  {
    get
    {
      return _Element?.DiagramLayoutMostRecentUsed?.Value;
    }
    set
    {
      _ExistingElement.DiagramLayoutMostRecentUsed = value;
    }
  }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  [DataMember]
  public DM.Base64Binary? Gfxdata
  {
    get
    {
      return Base64BinaryConverter.GetValue(_Element?.Gfxdata);
    }
    set
    {
      _ExistingElement.Gfxdata = Base64BinaryConverter.CreateBase64BinaryValue(value);
    }
  }
  
  
  /// <summary>
  ///   Table Properties
  /// </summary>
  [DataMember]
  public String? TableProperties
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.TableProperties);
    }
    set
    {
      _ExistingElement.TableProperties = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Table Row Height Limits
  /// </summary>
  [DataMember]
  public String? TableLimits
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.TableLimits);
    }
    set
    {
      _ExistingElement.TableLimits = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
