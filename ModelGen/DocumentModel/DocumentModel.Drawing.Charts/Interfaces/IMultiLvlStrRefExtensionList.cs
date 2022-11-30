namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public interface IMultiLvlStrRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IMultiLvlStrRefExtension>? MultiLvlStrRefExtensions { get ; set; }
  
}
