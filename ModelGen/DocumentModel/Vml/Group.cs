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
  public DM.TrueFalseValue? Print
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? Oned
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? DoubleClickNotify
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   button
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Button
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   userhidden
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? UserHidden
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   bullet
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Bullet
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   hr
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Horizontal
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   hrstd
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? HorizontalStandard
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   hrnoshade
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? HorizontalNoShade
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? AllowInCell
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   allowoverlap
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowOverlap
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   userdrawn
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? UserDrawn
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
      if (_Element?.Gfxdata?.Value != null)
        return Convert.FromBase64String(_ExistingElement.Gfxdata.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.Gfxdata = Convert.ToBase64String(value);
      else
        _ExistingElement.Gfxdata = null;
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
