namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a list of entries which describe how shapes were previously grouped so they can be regrouped. 
/// The regroupid attribute of shapes indicates which shapes belong together when a regroup is performed. 
/// The regrouptable tracks the previous regroupid that should be assigned to all shapes with the given current regroupid.
/// </summary>
public partial class RegroupTable : ModelElement<DXVO.RegroupTable>
{
  public RegroupTable(): base(){ }

  public RegroupTable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public RegroupTable(DXVO.RegroupTable openXmlElement): base(openXmlElement) { } 

  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  [DataMember]
  public DMV.ExtensionHandlingBehaviorKind? Extension
  {
    get => _Element?.Extension?.GetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>();
    set => _ExistingElement.Extension = EVU.SetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>(value);
  }

}
