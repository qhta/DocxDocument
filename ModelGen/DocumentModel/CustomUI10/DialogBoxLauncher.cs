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
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.ButtonRegular>();
      if (element != null)
        return ButtonRegularConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.ButtonRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.ButtonRegular>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
