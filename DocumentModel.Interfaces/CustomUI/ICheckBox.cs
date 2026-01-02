namespace DocumentModel;

/// <summary>
///   This element specifies a standard checkbox control. 
/// </summary>
public interface ICheckBox: IModelElement, ICustomControlBase, IBuiltInControl, ITaggedObject, 
  IVisibleControl, IEnableControl, IDescriptionControl, IScreenTipControl, ISupertipControl, IKeyTipControl,
  ILabelControl, IImageControl,
  IActionControl, IPressedControl
{
}