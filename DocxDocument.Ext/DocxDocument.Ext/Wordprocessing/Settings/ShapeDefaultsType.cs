namespace DocumentModel.Wordprocessing;

/// <summary>
///  This class specifies the defaults that are used when creating new shapes. These defaults are stored once per document.
/// </summary>
[DataContract]
public partial class ShapeDefaultsType : IOpenXmlElementMappedObject
{
  public ShapeDefaultsType()
  {
    _Element = new DXW.ShapeDefaults();
  }

  public ShapeDefaultsType(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DXW.ShapeDefaults shapeDefaults)
      _Element = shapeDefaults;
    else
    if (openXmlElement is DXW.HeaderShapeDefaults headerShapeDefaults)
    {
      _Element = headerShapeDefaults;
    }
    else
      throw new InvalidOperationException($"SourceElement must be of ShapeDefaults or HeaderShapeDefaults type");

  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType shapeDefaults)
      return shapeDefaults;
    DXW.ShapeDefaultsType result;
    if (typeof(OpenXmlElementType) == typeof(DXW.ShapeDefaults))
      result = new DXW.ShapeDefaults();
    else
    if (typeof(OpenXmlElementType) == typeof(DXW.HeaderShapeDefaults))
      result = new DXW.HeaderShapeDefaults();
    else
      throw new InvalidOperationException($"Element type {typeof(OpenXmlElementType)} not supported");

    var vmlShapeDefaults = VmlShapeDefaults?.GetElement<DXVO.ShapeDefaults>();
    if (vmlShapeDefaults != null)
      result.AddChildElement(vmlShapeDefaults);
    var vmlShapeLayout = VmlShapeLayout?.GetElement<DXVO.ShapeLayout>();
    if (vmlShapeLayout != null)
      result.AddChildElement(vmlShapeLayout);

    if (result is OpenXmlElementType obj)
      return obj;

    throw new InvalidOperationException($"Element type {typeof(OpenXmlElementType)} not supported");
  }

  public ShapeDefaultsType(DXW.ShapeDefaultsType openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.ShapeDefaultsType _Element { get; private set; }

  [DataMember]
  public DMV.ShapeDefaults? VmlShapeDefaults
  {
    get => _Element.GetObject<DMV.ShapeDefaults, DXVO.ShapeDefaults>();
    set => _Element.SetObject<DMV.ShapeDefaults, DXVO.ShapeDefaults>(value);
  }

  [DataMember]
  public DMV.ShapeLayout? VmlShapeLayout
  {
    get => _Element.GetObject<DMV.ShapeLayout, DXVO.ShapeLayout>();
    set => _Element.SetObject<DMV.ShapeLayout, DXVO.ShapeLayout>(value);
  }

}
