namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the DialogBoxLauncher Class.
/// </summary>
public partial class DialogBoxLauncher: ModelElement<DXO10CUI.DialogBoxLauncher>
{
  public DialogBoxLauncher(): base(){ }
  
  public DialogBoxLauncher(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DialogBoxLauncher(DXO10CUI.DialogBoxLauncher openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ButtonRegular.
  /// </summary>
  [DataMember]
  public DMCUI10.ButtonRegular? ButtonRegular
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
