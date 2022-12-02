namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public interface IMultiLvlStrRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IMultiLvlStrRefExtension>? MultiLvlStrRefExtensions { get ; set; }
  
}
