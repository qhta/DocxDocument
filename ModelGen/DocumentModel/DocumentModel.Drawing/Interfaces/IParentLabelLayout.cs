namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public interface IParentLabelLayout // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public ParentLabelLayoutVal? ParentLabelLayoutVal { get ; set; }
  
}
