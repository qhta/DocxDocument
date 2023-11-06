namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a list of entries which describe how shapes were previously grouped so they can be regrouped. 
/// The regroupid attribute of shapes indicates which shapes belong together when a regroup is performed. 
/// The regrouptable tracks the previous regroupid that should be assigned to all shapes with the given current regroupid.
/// </summary>
public partial class RegroupTable : IOpenXmlElementMappedObject
{
  public RegroupTable()
  {
    _Element = new DXVO.RegroupTable();
  }

  public RegroupTable(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXVO.RegroupTable)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public RegroupTable(DXVO.RegroupTable openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXVO.RegroupTable _Element { get; private set; }



  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  [DataMember]
  public DMV.ExtensionHandlingBehaviorKind? Extension
  {
    get => _Element.Extension?.GetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>();
    set => _Element.Extension = EVU.SetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>(value);
  }

}
