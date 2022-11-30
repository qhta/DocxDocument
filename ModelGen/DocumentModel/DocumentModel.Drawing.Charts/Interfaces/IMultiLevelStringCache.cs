namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public interface IMultiLevelStringCache // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ILevel>? Levels { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
