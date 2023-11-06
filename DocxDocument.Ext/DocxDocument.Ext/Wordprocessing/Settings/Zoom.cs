namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the magnification level which should be applied to a document when it is displayed by an application. 
/// The zoom level is specified with the use of two attributes stored on this element:
/// <list type="bullet">
///   <item>val, which stores the type of zoom applied to the document</item>
///   <item>percent, which stores the zoom percentage to be used when rendering the document</item>
/// </list>
/// If both attributes are present, then the percent attribute shall be treated as a 'cached' value and only used when the value none is specified for the val attribute.
/// </summary>

[DataContract]
public partial class Zoom : IOpenXmlElementMappedObject
{
  public Zoom()
  {
    _Element = new DXW.Zoom();
  }

  public Zoom(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.Zoom)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_ExistingElement is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_ExistingElement.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public Zoom(DXW.Zoom openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.Zoom? _Element { get; private set; }
  internal DXW.Zoom _ExistingElement
  {
    get
    {
      if (_Element == null)
      {
        _Element = new DXW.Zoom();
      }
      return _Element;
    }
    private set => _Element = value;
  }

  [DataMember]
  public DMW.PresetZoomKind? Val
  {
    get => _Element?.Val?.GetEnumValue<DMW.PresetZoomKind, DXW.PresetZoomValues>();
    set => _ExistingElement.Val = EVU.SetEnumValue<DMW.PresetZoomKind, DXW.PresetZoomValues>(value);
  }

  [DataMember]
  public Percent? Percent
  {
    get
    {
      var val = _Element?.Percent?.Value;
      if (val == null)
        return null;
      return new Percent(val);
    }
    set
    {
      if (value is not null)
        _ExistingElement.Percent = value.ToString();
      else
        _ExistingElement.Percent = null;
    }
  }

}
