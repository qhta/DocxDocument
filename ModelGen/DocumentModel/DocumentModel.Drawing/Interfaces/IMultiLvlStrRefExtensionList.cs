namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public interface IMultiLvlStrRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IMultiLvlStrRefExtension>? MultiLvlStrRefExtensions { get ; set; }
  
}
