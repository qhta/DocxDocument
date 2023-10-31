namespace DocumentModel.Wordprocessing;

/// <summary>
///  This element specifies the defaults that are used when creating new shapes. These defaults are stored once per document.
/// </summary>
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

    var shapeDefaultsVml = ShapeDefaults?.GetElement<DXVO.ShapeDefaults>();
    if (shapeDefaultsVml != null)
      result.AppendChild(shapeDefaultsVml);
    var shapeLayout = ShapeLayout?.GetElement<DXVO.ShapeLayout>();
    if (shapeLayout != null)
      result.AppendChild(shapeLayout);

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
  public DMV.ShapeDefaults? ShapeDefaults
  {
    get => _Element.GetObject<DMV.ShapeDefaults, DXVO.ShapeDefaults>();
    set => _Element.SetObject<DMV.ShapeDefaults, DXVO.ShapeDefaults>(value);
  }

  [DataMember]
  public DMV.ShapeLayout? ShapeLayout
  {
    get => _Element.GetObject<DMV.ShapeLayout, DXVO.ShapeLayout>();
    set => _Element.SetObject<DMV.ShapeLayout, DXVO.ShapeLayout>(value);
  }

}
