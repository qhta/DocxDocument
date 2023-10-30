namespace DocumentModel.Wordprocessing;

/// <summary>
/// This element specifies the magnification level which should be applied to a document when it is displayed by an application. 
/// The zoom level is specified with the use of two attributes stored on this element:
/// <list type="bullet">
///   <item>val, which stores the type of zoom applied to the document</item>
///   <item>percent, which stores the zoom percentage to be used when rendering the document</item>
/// </list>
/// If both attributes are present, then the percent attribute shall be treated as a 'cached' value and only used when the value none is specified for the val attribute.
/// </summary>
public partial class Zoom
{
  public Zoom(DXW.Zoom openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.Zoom _Element { get; private set; }


  public DXW.PresetZoomValues? Val
  {
    get => _Element.Val?.Value;
    set
    {
      if (value != null)
        _Element.Val = new DX.EnumValue<DXW.PresetZoomValues> { Value = (DXW.PresetZoomValues)value };
      else
        _Element.Val = null;
    }
  }

  public Percent? Percent
  {
    get
    {
      var val = _Element.Percent?.Value;
      if (val == null)
        return null;
      return new Percent(val);
    }
    set
    {
      if (value is not null)
        _Element.Percent = value.ToString();
      else
        _Element.Percent = null;
    }
  }

}
