namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public partial class QuickAccessToolbar: ModelElement<DXOCUI.QuickAccessToolbar>
{
  public QuickAccessToolbar(): base(){ }
  
  public QuickAccessToolbar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public QuickAccessToolbar(DXOCUI.QuickAccessToolbar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SharedQatControls.
  /// </summary>
  [DataMember]
  public DMCUI.SharedQatControls? SharedQatControls
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office.CustomUI.QatItemsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office.CustomUI.QatItemsType");
  }
  
  
  /// <summary>
  ///   DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  [DataMember]
  public DMCUI.DocumentSpecificQuickAccessToolbarControls? DocumentSpecificQuickAccessToolbarControls
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office.CustomUI.QatItemsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office.CustomUI.QatItemsType");
  }
  
}
