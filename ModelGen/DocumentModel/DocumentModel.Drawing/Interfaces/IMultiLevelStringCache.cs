namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public interface IMultiLevelStringCache // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ILevel>? Levels { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
