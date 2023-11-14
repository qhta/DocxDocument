namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a list of entries which describe how shapes were previously grouped so they can be regrouped. 
/// The regroupid attribute of shapes indicates which shapes belong together when a regroup is performed. 
/// The regrouptable tracks the previous regroupid that should be assigned to all shapes with the given current regroupid.
/// </summary>
public partial class RegroupTable : ModelElementCollection<DXVO.RegroupTable, DXVO.Entry, DMV.Entry>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public RegroupTable(): base(){ }

  public RegroupTable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public RegroupTable(DXVO.RegroupTable openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

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
