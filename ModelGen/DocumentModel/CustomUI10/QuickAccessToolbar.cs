namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public partial class QuickAccessToolbar: ModelElement<DXO10CUI.QuickAccessToolbar>
{
  public QuickAccessToolbar(): base(){ }
  
  public QuickAccessToolbar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public QuickAccessToolbar(DXO10CUI.QuickAccessToolbar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SharedControlsQatItems.
  /// </summary>
  [DataMember]
  public DMCUI10.SharedControlsQatItems? SharedControlsQatItems
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.CustomUI.QatItemsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.CustomUI.QatItemsType");
  }
  
  
  /// <summary>
  ///   DocumentControlsQatItems.
  /// </summary>
  [DataMember]
  public DMCUI10.DocumentControlsQatItems? DocumentControlsQatItems
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.CustomUI.QatItemsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.CustomUI.QatItemsType");
  }
  
}
