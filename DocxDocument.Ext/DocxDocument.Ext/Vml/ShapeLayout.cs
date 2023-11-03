namespace DocumentModel.Vml;

/// <summary>
/// This class specifies the defaults that are used when creating new shapes. These defaults are stored once per document.
/// </summary>
public partial class ShapeLayout : IOpenXmlElementMappedObject
{
  public ShapeLayout()
  {
    _Element = new DXVO.ShapeLayout();
  }

  public ShapeLayout(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXVO.ShapeLayout)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public ShapeLayout(DXVO.ShapeLayout openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXVO.ShapeLayout _Element { get; private set; }

  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  [DataMember]
  public DMV.ShapeIdMap? ShapeIdMap
  {
    get => _Element.GetObject<DMV.ShapeIdMap, DXVO.ShapeIdMap>(); 
    set => _Element.SetObject<DMV.ShapeIdMap, DXVO.ShapeIdMap>(value); 
  }

  [DataMember]
  public DMV.Rules? Rules
  {
    get => _Element.GetObject<DMV.Rules, DXVO.Rules>(); 
    set => _Element.SetObject<DMV.Rules, DXVO.Rules>(value); 
  }

  [DataMember]
  public DMV.RegroupTable? RegroupTable
  {
    get => _Element.GetObject<DMV.RegroupTable, DXVO.RegroupTable>(); 
    set => _Element.SetObject<DMV.RegroupTable, DXVO.RegroupTable>(value); 
  }

  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  [DataMember]
  public DXV.ExtensionHandlingBehaviorValues? Extension
  {
    get => _Element.Extension?.Value;
    set => _Element.Extension = value;
  }
}
